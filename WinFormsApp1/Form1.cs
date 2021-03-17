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
            if (loadFileNameTxtBox.Text == "Enter file name with .dat extension" || loadFileNameTxtBox.Text == string.Empty)
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

                    for (int i = 0; i < Program.currentList.Count(); i++)
                    {
                        removeWordsCheckedListBox.Items.Add(Program.currentList[i].Translations[0], false);
                    }

                    removeFromLangComboBox.Items.AddRange(Program.currentList.Languages);

                    removeFromLangComboBox.SelectedIndex = 0;
                }
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (createListFileNameTxtBox.Text == "Enter file name with .dat extension" || createListFileNameTxtBox.Text == string.Empty)
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
    }
}
