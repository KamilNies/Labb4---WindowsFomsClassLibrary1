using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WordList
    {
        //Read-only field
        public static readonly string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Labb4WorkShopApp"); //TODO: Change Labb4WorkShopApp

        //Auto-implemented properties
        public string Name { get; }
        public string[] Languages { get; }
        private List<Word> Words { get; set; }

        //Constructor
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = new string[languages.Length];
            for (int i = 0; i < languages.Length; i++)
            {
                Languages[i] = languages[i].ToLower();
            }
        }

        public Word this[int i]
        {
            get => Words[i];
        }

        //Methods
        public static string[] GetLists()
        {
            string[] files = Directory.GetFiles(folder, "*.dat", SearchOption.AllDirectories);
            string[] nameArray = new string[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                nameArray[i] = Path.GetFileNameWithoutExtension(files[i]);
            }

            return nameArray;
        }
        public static WordList LoadList(string name)
        {
            if (File.Exists(Path.Combine(folder, name + ".dat")))
            {
                string[] content = File.ReadAllLines(Path.Combine(folder, name + ".dat"));
                if (content.Length > 0)
                {
                    string[] languages = content[0].Split(';', StringSplitOptions.RemoveEmptyEntries);
                    WordList wordList = new WordList(name, languages);
                    wordList.Words = new List<Word>();

                    for (int i = 1; i < content.Length; i++)
                    {
                        wordList.Words.Add(new Word(content[i].Split(';', StringSplitOptions.RemoveEmptyEntries)));
                    }

                    return wordList;
                }
                else
                {
                    return null; ;
                }
            }
            else
            {
                return null;
            }
        }
        public void Save()
        {
            using (var sw = new StreamWriter(Path.Combine(folder, Name + ".dat")))
            {
                sw.WriteLine(string.Join(";", Languages));
                if (Words != null)
                {
                    for (int i = 0; i < Words.Count; i++)
                    {
                        sw.WriteLine(string.Join(";", Words[i].Translations));
                    }
                } 
            }
        }
        public void Add(params string[] translations) => Words.Add(new Word(translations));


        /// <summary>
        /// Sök igenom språket och ta bort ordet. 
        /// </summary>
        /// <param name="translation">Motsvarar index i this.Languages</param>
        /// <param name="wordStr">Ordet som ska sökas efter och tas bort.</param>
        /// <returns></returns>
        public bool Remove(int translation, string wordStr)
        {
            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Translations[translation].Equals(wordStr, StringComparison.InvariantCulture))
                {
                    Words.RemoveAt(i);
                    return true;
                }
            }
            return false;
            //TODO Ta bort alla översatta ord eller bara det på det angivna språket?
        }
        public int Count()
        {
            if (Words != null)
            {
                return Words.Count;
            }
            return 0;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            if (sortByTranslation < 0 || sortByTranslation > Languages.Count() - 1)
            {
                throw new ArgumentOutOfRangeException($"Index {sortByTranslation} is out of range");
            }

            foreach (var word in Words.OrderBy(w => w.Translations[sortByTranslation]).ToList())
            {
                showTranslations?.Invoke(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            Random rng = new Random();
            if (Words != null)
            {
                int fromLanguages = rng.Next(Languages.Length), toLanguages = rng.Next(Languages.Length);
                while (fromLanguages == toLanguages)
                {
                    fromLanguages = rng.Next(Languages.Length);
                    toLanguages = rng.Next(Languages.Length);
                }
                return new Word(fromLanguages, toLanguages, Words[rng.Next(Words.Count)].Translations);
            }
            throw new ArgumentNullException("No Word objects found");
        }

        public static WordList LoadList2(string name)
        {
            string[] languages;
            WordList result = null;

            try
            {
                var dirInfo = Directory.CreateDirectory(folder);
                string destFilePath = Path.Combine(dirInfo.FullName, $"{name}.dat");

                if (!File.Exists(destFilePath))
                {
                    string sourcefilePath = $@"..\..\..\{name}.dat";

                    try
                    {
                        File.Copy(sourcefilePath, destFilePath);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine($"Error: The Word List {name}.dat does not exist inside {dirInfo.FullName} nor could be copied over from from {Directory.GetCurrentDirectory()}.");

                        Console.ForegroundColor = ConsoleColor.Gray;

                        return null;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return null;
                    }
                }
                using (var reader = new StreamReader(destFilePath))
                {
                    languages = reader.ReadLine().Split(';').Where(s => s != string.Empty).ToArray();

                    result = new WordList(name, languages);

                    string nextLine;

                    while ((nextLine = reader.ReadLine()) != null)
                    {
                        result.Add(nextLine.Split(';').Where(s => s != string.Empty).ToArray());
                    }
                }

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}
