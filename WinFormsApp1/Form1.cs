using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set Button BG Images
            //**********************************************************************************************************
            loadButton.BackgroundImage = LoadImage("formButtonBackgroundSmaller.png");

            createButton.BackgroundImage = LoadImage("formButtonBackgroundSmaller.png");

            addButton.BackgroundImage = LoadImage("formButtonBackgroundSmaller.png");

            removeWordsButton.BackgroundImage = LoadImage("formButtonBackgroundSmaller.png");

            Sort_Button.BackgroundImage = LoadImage("formButtonBackgroundSmaller.png");

            //**********************************************************************************************************
            // Set Panel BG Images
            //**********************************************************************************************************
            loadPanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");

            createPanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");

            sortPanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");

            addPanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");

            removePanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");

            loadPanel.BackgroundImage = LoadImage("beveledBackgroundPanelNewe.png");
            //**********************************************************************************************************
            // Set Picture Box Images
            //**********************************************************************************************************
            loadPictureBox.Image = LoadImage("openWhite.png");

            createPictureBox.Image = LoadImage("newlistWhile.png");

            sortPictureBox.Image = LoadImage("sortWhite.png");

            removePictureBox.Image = LoadImage("removeWhite.png");

            addPictureBox.Image = LoadImage("addWhite.png");

            githubPictureBox.Image = LoadImage("github.png");
            //**********************************************************************************************************
            // Set Form1 BG Image
            //**********************************************************************************************************
            this.BackgroundImage = LoadImage("background gradient.png");

            Image LoadImage(string fileName)
            {
                return Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "Images", fileName));
            }
        }

        

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (loadFileNameTxtBox.Text == "Enter file name without .dat extension" || loadFileNameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Program.currentList = WordList.LoadList(loadFileNameTxtBox.Text);
                if (Program.currentList == null)
                {
                    fileLoadedLabel.ForeColor = Color.DarkRed;
                    fileLoadedLabel.Text = "Cannot find file. File not loaded.";
                }
                else
                {
                    fileLoadedLabel.ForeColor = Color.Green;
                    fileLoadedLabel.Text = $"{Program.currentList.Name}.dat loaded. Contains: {Program.currentList.Count()} word objects";

                    removeWordsCheckedListBox.Items.Clear();
                    removeFromLangComboBox.Items.Clear();

                    for (int i = 0; i < Program.currentList.Count(); i++)
                    {
                        removeWordsCheckedListBox.Items.Add(Program.currentList[i].Translations[0], false);
                    }

                    removeFromLangComboBox.Items.AddRange(Program.currentList.Languages);

                    removeFromLangComboBox.SelectedIndex = 0;

                    outputTxtBox.Text = $"{Program.currentList.Name}.dat loaded. Contains: " + Environment.NewLine + Environment.NewLine;
                    outputTxtBox.Text += string.Join(", ", Program.currentList.Languages);

                    Action<string[]> action = new Action<string[]>(ShowTranslations);
                    Program.currentList.GetCurrentList(action);
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (createListFileNameTxtBox.Text == "Enter file name without .dat extension" || createListFileNameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("File textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (createListLanguageTxtBox.Text == "Enter all languages seperated by space" || createListLanguageTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Language textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string fileName = createListFileNameTxtBox.Text;
                string[] createLanguagesArray = createListLanguageTxtBox.Text
                    .Split(new char[] { ' ', '.', ',', ';', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (createLanguagesArray.Length < 2)
                {
                    MessageBox.Show("You need need at least two languages. Input some more languages.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Program.currentList = new WordList(fileName, createLanguagesArray);
                Program.currentList.Save();

                if (Program.currentList == null)
                {
                    fileLoadedLabel.ForeColor = Color.DarkRed;
                    fileLoadedLabel.Text = "Cannot find file. File not loaded.";
                }
                else
                {
                    fileLoadedLabel.ForeColor = Color.Green;
                    fileLoadedLabel.Text = $"{Program.currentList.Name}.dat loaded. Contains: {Program.currentList.Count()} word objects";
                }

                outputTxtBox.Text = $"{Program.currentList.Name}.dat successfully created.";

                removeFromLangComboBox.Items.AddRange(Program.currentList.Languages);

                removeFromLangComboBox.SelectedIndex = 0;
            }
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeApplicationButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (SortListTxtBox.Text == "Enter language of choice" || SortListTxtBox.Text == "")
            {
                MessageBox.Show("Textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int counter = 0;
                outputTxtBox.Text = string.Join(", ", Program.currentList.Languages);
                for (int i = 0; i < Program.currentList.Languages.Length; i++)
                {
                    if (SortListTxtBox.Text.ToLower() == Program.currentList.Languages[i])
                    {
                        Action<string[]> action = new Action<string[]>(ShowTranslations);
                        Program.currentList.List(i, action);
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    MessageBox.Show("Could not find language!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowTranslations(string[] words)
        {
            string newLine = Environment.NewLine;
            outputTxtBox.Text += newLine + string.Join(", ", words);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var wordList = Program.currentList;

            if (addWordsTextBox.Text == "Enter all the words you wish to add here" || createListFileNameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("File textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (wordList == null)
            {
                MessageBox.Show("Fail! You must first load a WordList object.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] addedTranslations = addWordsTextBox.Text.ToLower()
                .Split(new char[] { ',', '.', ' ', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);

            if (addedTranslations.Length == 0 || addedTranslations.Length % wordList.Languages.Length != 0)
            {
                MessageBox.Show("Fail! You must enter at least one word for every language.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int wordCount = addedTranslations.Length / wordList.Languages.Length;

            for (var i = 0; i < wordCount; i++)
            {
                wordList.Add(addedTranslations.Skip(i * wordList.Languages.Length).Take(wordList.Languages.Length).ToArray());
            }

            wordList.Save();

            outputTxtBox.Text = "Words were successfully added to the list!";

            UpdateRemoveWordsCheckedListBox();

            fileLoadedLabel.ForeColor = Color.Green;
            fileLoadedLabel.Text = $"{Program.currentList.Name}.dat loaded. Contains: {Program.currentList.Count()} word objects";
        }
        private void UpdateRemoveWordsCheckedListBox()
        {
            removeWordsCheckedListBox.Items.Clear();

            if (removeFromLangComboBox.SelectedIndex == -1)
                removeFromLangComboBox.SelectedIndex = 0;

            for (int i = 0; i < Program.currentList.Count(); i++)
            {
                removeWordsCheckedListBox.Items.Add(Program.currentList[i].Translations[removeFromLangComboBox.SelectedIndex], false);
            }
        }

        public void RemoveWords(object sender, EventArgs e)
        {
            var wordList = Program.currentList;

            if (wordList == null)
            {
                MessageBox.Show("Fail! You must first load a Wordlist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string language = removeFromLangComboBox.Text;
            var wordItemsToBeRemoved = removeWordsCheckedListBox.CheckedItems;

            if (wordItemsToBeRemoved.Count == 0)
            {
                MessageBox.Show("Fail! You must enter at least one word.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (wordItemsToBeRemoved.Count > 0)
            {
                wordList.Remove(removeFromLangComboBox.SelectedIndex, wordItemsToBeRemoved[0].ToString());
                removeWordsCheckedListBox.Items.Remove(wordItemsToBeRemoved[0]);
            }

            wordList.Save();

            fileLoadedLabel.ForeColor = Color.Green;
            fileLoadedLabel.Text = $"{Program.currentList.Name}.dat loaded. Contains: {Program.currentList.Count()} word objects";

            outputTxtBox.Text = "Words were successfully removed!";
        }

        private void removeWordsButton_Click(object sender, EventArgs e)
        {
            RemoveWords(sender, e);
        }

        private void removeFromLangComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateRemoveWordsCheckedListBox();
        }

        private void startPractice_Click(object sender, EventArgs e)
        {
            outputTxtBox.Text = "Test has started..." + Environment.NewLine + Environment.NewLine;
            if (Program.currentList == null)
            {
                MessageBox.Show("You must load a list before you start practice.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            startPractice.Enabled = false;
            removeWordsCheckedListBox.Visible = false;
            exitPractice.Enabled = true;
            checkPracticeWord.Enabled = true;
            Sort_Button.Enabled = false;
            removeWordsButton.Enabled = false;
            addButton.Enabled = false;
            loadButton.Enabled = false;
            createButton.Enabled = false;
            clearButton.Enabled = false;

            Program.rngWord = Program.currentList.GetWordToPractice();
            string toLanguage = Program.currentList.Languages[Program.rngWord.ToLanguage];
            string fromLanguage = Program.rngWord.Translations[Program.rngWord.FromLanguage];
            showWords.Text = $"\"{fromLanguage}\" to {toLanguage}";
        }

        private void checkPracticeWord_Click(object sender, EventArgs e)
        {
            if (practiceTxtBox.Text == "Enter word" || practiceTxtBox.Text == string.Empty)
            {
                MessageBox.Show("Textbox cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (practiceTxtBox.Text.ToLower() == Program.rngWord.Translations[Program.rngWord.ToLanguage])
            {
                practicePanel.BackColor = Color.FromArgb(34, 139, 34);
                practiceTxtBox.BackColor = Color.FromArgb(34, 139, 34);
                outputTxtBox.Text += "Correct!" + Environment.NewLine;

                Program.rngWord = Program.currentList.GetWordToPractice();
                string toLanguage = Program.currentList.Languages[Program.rngWord.ToLanguage];
                string fromLanguage = Program.rngWord.Translations[Program.rngWord.FromLanguage];
                showWords.Text = $"\"{fromLanguage}\" to {toLanguage}";
                practiceTxtBox.Text = "";
                Program.numerator++;
                Program.denominator++;

            }
            else
            {
                practicePanel.BackColor = Color.FromArgb(178, 34, 34);
                practiceTxtBox.BackColor = Color.FromArgb(178, 34, 34);
                outputTxtBox.Text += $"Incorrect! The correct word was: {Program.rngWord.Translations[Program.rngWord.ToLanguage]}" + Environment.NewLine;

                Program.rngWord = Program.currentList.GetWordToPractice();
                string toLanguage = Program.currentList.Languages[Program.rngWord.ToLanguage];
                string fromLanguage = Program.rngWord.Translations[Program.rngWord.FromLanguage];
                showWords.Text = $"\"{fromLanguage}\" to {toLanguage}";
                practiceTxtBox.Text = "";
                Program.denominator++;
            }
        }

        private void exitPractice_Click(object sender, EventArgs e)
        {
            startPractice.Enabled = true;
            removeWordsCheckedListBox.Visible = true;
            exitPractice.Enabled = false;
            checkPracticeWord.Enabled = false;
            Sort_Button.Enabled = true;
            removeWordsButton.Enabled = true;
            addButton.Enabled = true;
            loadButton.Enabled = true;
            createButton.Enabled = true;
            clearButton.Enabled = true;

            outputTxtBox.Text += Environment.NewLine + $"You got {Program.numerator}/{Program.denominator} correct!";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Program.currentList = null;
            Program.currentList = null;
            Program.rngWord = null;
            Program.numerator = 0;
            Program.denominator = 0;


            addButton.Enabled = true;
            addWordsTextBox.Text = "Enter all the words you wish to add here";
            checkPracticeWord.Enabled = false;
            clearButton.Enabled = true;
            createButton.Enabled = true;
            createListFileNameTxtBox.Text = "Enter file name without .dat extension";
            createListLanguageTxtBox.Text = "Enter all languages separated by space";
            exitPractice.Enabled = false;
            fileLoadedLabel.Text = "No list loaded";
            fileLoadedLabel.ForeColor = Color.Black;
            loadButton.Enabled = true;
            loadFileNameTxtBox.Text = "Enter file name without .dat extension";
            outputTxtBox.Text = ""; //TODO change this
            practicePanel.BackColor = Color.FromArgb(178, 34, 34);
            practiceTxtBox.Text = "Enter word";
            practiceTxtBox.BackColor = Color.FromArgb(178, 34, 34);
            removeWordsButton.Enabled = true;
            showWords.Text = "Word";
            Sort_Button.Enabled = true;
            SortListTxtBox.Text = "Enter language of choice";
            startPractice.Enabled = true;

        }

       
    }
}
