using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

                outputTxtBox.Text = string.Empty;
                outputTxtBox.Text = $"{Program.currentList.Name}.dat successfully created.";
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
    }
}
