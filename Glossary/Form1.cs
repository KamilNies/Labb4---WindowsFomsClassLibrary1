using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Glossary
{
    public partial class Form1 : Form
    {
        static List<WordList> loadedWordListObjects = new List<WordList>();

        public Form1()
        {
            InitializeComponent();
        }

        private void getListButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            var test = WordList.GetLists();
            foreach (var item in test)
            {
                textBox1.Text += item + Environment.NewLine;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            if (inputTxtBox.Text == "Input text here" || inputTxtBox.Text == "" || inputTxtBox.Text == " ")
            {
                MessageBox.Show("Textbox cannot be empty.");
                return;
            }
            textBox1.Text = null;
            string[] parameters = inputTxtBox.Text
                .Split(new char[] { ' ', '.', ',', ';', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
            if (parameters.Length > 2)
            {
                loadedWordListObjects.Add(new WordList(parameters[0], parameters[1..(parameters.Length)]));
                textBox1.Text = "Awaiting input...";
                inputTxtBox.Text = "Input all the languages here";
                label1.Text = "Lists loaded: " + loadedWordListObjects.Count();
            }
            else
            {
                throw new ArgumentException("parameters.Length < 3. Not enough parameters: <file name> <language 1> .. <language n>");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var test = textBox2.Text;
            var wordListObject = WordList.LoadList(test);
            loadedWordListObjects.Add(wordListObject);
            if (loadedWordListObjects.Count > 0 && loadedWordListObjects[0] != null)
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = $"{loadedWordListObjects[0]} is loaded";
            }
            else
            {
                label2.Text = $"Cannot find file";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
