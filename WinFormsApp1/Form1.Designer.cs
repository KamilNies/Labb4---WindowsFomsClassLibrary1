
using System.IO;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createPanel = new System.Windows.Forms.Panel();
            this.createPictureBox = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.createListLanguageTxtBox = new System.Windows.Forms.TextBox();
            this.createListFileNameTxtBox = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addPictureBox = new System.Windows.Forms.PictureBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addWordsTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.loadFNComboBox = new System.Windows.Forms.ComboBox();
            this.loadPictureBox = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.removePanel = new System.Windows.Forms.Panel();
            this.removeFromLangComboBox = new System.Windows.Forms.ComboBox();
            this.removeWordsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.removePictureBox = new System.Windows.Forms.PictureBox();
            this.removeWordsButton = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sortPanel = new System.Windows.Forms.Panel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortPictureBox = new System.Windows.Forms.PictureBox();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.githubPictureBox = new System.Windows.Forms.PictureBox();
            this.exitApplicationButton = new System.Windows.Forms.Button();
            this.minimizeApplicationButton = new System.Windows.Forms.Button();
            this.fileLoadedLabel = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.outputTxtBox = new System.Windows.Forms.TextBox();
            this.practicePanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.exitPractice = new System.Windows.Forms.Button();
            this.startPractice = new System.Windows.Forms.Button();
            this.checkPracticeWord = new System.Windows.Forms.Button();
            this.practiceTxtBox = new System.Windows.Forms.TextBox();
            this.showWords = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.createPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).BeginInit();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).BeginInit();
            this.removePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).BeginInit();
            this.sortPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).BeginInit();
            this.panel13.SuspendLayout();
            this.practicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.Transparent;
            this.createPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createPanel.Controls.Add(this.createPictureBox);
            this.createPanel.Controls.Add(this.createButton);
            this.createPanel.Controls.Add(this.createListLanguageTxtBox);
            this.createPanel.Controls.Add(this.createListFileNameTxtBox);
            this.createPanel.Controls.Add(this.panel11);
            this.createPanel.Controls.Add(this.label11);
            this.createPanel.Controls.Add(this.panel14);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.panel2);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Location = new System.Drawing.Point(1107, 159);
            this.createPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(360, 367);
            this.createPanel.TabIndex = 0;
            // 
            // createPictureBox
            // 
            this.createPictureBox.Location = new System.Drawing.Point(270, 25);
            this.createPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createPictureBox.Name = "createPictureBox";
            this.createPictureBox.Size = new System.Drawing.Size(67, 79);
            this.createPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createPictureBox.TabIndex = 5;
            this.createPictureBox.TabStop = false;
            // 
            // createButton
            // 
            this.createButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createButton.Location = new System.Drawing.Point(23, 276);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(314, 67);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createListLanguageTxtBox
            // 
            this.createListLanguageTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.createListLanguageTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createListLanguageTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createListLanguageTxtBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createListLanguageTxtBox.Location = new System.Drawing.Point(23, 217);
            this.createListLanguageTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createListLanguageTxtBox.Name = "createListLanguageTxtBox";
            this.createListLanguageTxtBox.Size = new System.Drawing.Size(314, 20);
            this.createListLanguageTxtBox.TabIndex = 2;
            this.createListLanguageTxtBox.Text = "Enter all languages separated by space";
            this.createListLanguageTxtBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // createListFileNameTxtBox
            // 
            this.createListFileNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.createListFileNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createListFileNameTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createListFileNameTxtBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.createListFileNameTxtBox.Location = new System.Drawing.Point(23, 124);
            this.createListFileNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createListFileNameTxtBox.Name = "createListFileNameTxtBox";
            this.createListFileNameTxtBox.Size = new System.Drawing.Size(314, 20);
            this.createListFileNameTxtBox.TabIndex = 2;
            this.createListFileNameTxtBox.Text = "Enter file name without .dat extension";
            this.createListFileNameTxtBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel11.Location = new System.Drawing.Point(23, 247);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(314, 1);
            this.panel11.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(19, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Languages";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel14.Location = new System.Drawing.Point(0, 67);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(360, 1);
            this.panel14.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(23, 153);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 1);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "File name";
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPanel.Controls.Add(this.addPictureBox);
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.addWordsTextBox);
            this.addPanel.Controls.Add(this.panel4);
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.panel18);
            this.addPanel.Location = new System.Drawing.Point(1107, 533);
            this.addPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(360, 367);
            this.addPanel.TabIndex = 0;
            // 
            // addPictureBox
            // 
            this.addPictureBox.Location = new System.Drawing.Point(270, 29);
            this.addPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPictureBox.Name = "addPictureBox";
            this.addPictureBox.Size = new System.Drawing.Size(67, 80);
            this.addPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPictureBox.TabIndex = 5;
            this.addPictureBox.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addButton.Location = new System.Drawing.Point(23, 273);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(314, 67);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addWordsTextBox
            // 
            this.addWordsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.addWordsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addWordsTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addWordsTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.addWordsTextBox.Location = new System.Drawing.Point(23, 171);
            this.addWordsTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addWordsTextBox.Name = "addWordsTextBox";
            this.addWordsTextBox.Size = new System.Drawing.Size(314, 20);
            this.addWordsTextBox.TabIndex = 2;
            this.addWordsTextBox.Text = "Enter all the words you wish to add here";
            this.addWordsTextBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(23, 200);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 1);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add Words";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel18.Location = new System.Drawing.Point(0, 69);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(360, 1);
            this.panel18.TabIndex = 6;
            // 
            // loadPanel
            // 
            this.loadPanel.BackColor = System.Drawing.Color.Transparent;
            this.loadPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadPanel.Controls.Add(this.loadFNComboBox);
            this.loadPanel.Controls.Add(this.loadPictureBox);
            this.loadPanel.Controls.Add(this.loadButton);
            this.loadPanel.Controls.Add(this.panel15);
            this.loadPanel.Controls.Add(this.panel6);
            this.loadPanel.Controls.Add(this.label5);
            this.loadPanel.Controls.Add(this.label6);
            this.loadPanel.Location = new System.Drawing.Point(741, 159);
            this.loadPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(360, 367);
            this.loadPanel.TabIndex = 0;
            // 
            // loadFNComboBox
            // 
            this.loadFNComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.loadFNComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFNComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadFNComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loadFNComboBox.FormattingEnabled = true;
            this.loadFNComboBox.Location = new System.Drawing.Point(23, 177);
            this.loadFNComboBox.Name = "loadFNComboBox";
            this.loadFNComboBox.Size = new System.Drawing.Size(315, 29);
            this.loadFNComboBox.TabIndex = 6;
            // 
            // loadPictureBox
            // 
            this.loadPictureBox.Location = new System.Drawing.Point(269, 21);
            this.loadPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadPictureBox.Name = "loadPictureBox";
            this.loadPictureBox.Size = new System.Drawing.Size(69, 83);
            this.loadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadPictureBox.TabIndex = 5;
            this.loadPictureBox.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadButton.Location = new System.Drawing.Point(23, 276);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(314, 67);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel15.Location = new System.Drawing.Point(0, 67);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(360, 1);
            this.panel15.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(23, 205);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 1);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "File name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Load List";
            // 
            // removePanel
            // 
            this.removePanel.BackColor = System.Drawing.Color.Transparent;
            this.removePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removePanel.Controls.Add(this.removeFromLangComboBox);
            this.removePanel.Controls.Add(this.removeWordsCheckedListBox);
            this.removePanel.Controls.Add(this.removePictureBox);
            this.removePanel.Controls.Add(this.removeWordsButton);
            this.removePanel.Controls.Add(this.panel17);
            this.removePanel.Controls.Add(this.label7);
            this.removePanel.Controls.Add(this.label8);
            this.removePanel.Location = new System.Drawing.Point(741, 533);
            this.removePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removePanel.Name = "removePanel";
            this.removePanel.Size = new System.Drawing.Size(360, 367);
            this.removePanel.TabIndex = 0;
            // 
            // removeFromLangComboBox
            // 
            this.removeFromLangComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.removeFromLangComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFromLangComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeFromLangComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.removeFromLangComboBox.FormattingEnabled = true;
            this.removeFromLangComboBox.Location = new System.Drawing.Point(23, 120);
            this.removeFromLangComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removeFromLangComboBox.Name = "removeFromLangComboBox";
            this.removeFromLangComboBox.Size = new System.Drawing.Size(313, 29);
            this.removeFromLangComboBox.TabIndex = 7;
            this.removeFromLangComboBox.SelectedIndexChanged += new System.EventHandler(this.removeFromLangComboBox_SelectedIndexChanged_1);
            this.removeFromLangComboBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // removeWordsCheckedListBox
            // 
            this.removeWordsCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.removeWordsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.removeWordsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeWordsCheckedListBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.removeWordsCheckedListBox.FormattingEnabled = true;
            this.removeWordsCheckedListBox.Location = new System.Drawing.Point(23, 160);
            this.removeWordsCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeWordsCheckedListBox.Name = "removeWordsCheckedListBox";
            this.removeWordsCheckedListBox.Size = new System.Drawing.Size(313, 46);
            this.removeWordsCheckedListBox.TabIndex = 6;
            this.removeWordsCheckedListBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // removePictureBox
            // 
            this.removePictureBox.Location = new System.Drawing.Point(269, 29);
            this.removePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removePictureBox.Name = "removePictureBox";
            this.removePictureBox.Size = new System.Drawing.Size(67, 79);
            this.removePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removePictureBox.TabIndex = 5;
            this.removePictureBox.TabStop = false;
            // 
            // removeWordsButton
            // 
            this.removeWordsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeWordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeWordsButton.FlatAppearance.BorderSize = 0;
            this.removeWordsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeWordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeWordsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeWordsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeWordsButton.Location = new System.Drawing.Point(23, 273);
            this.removeWordsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeWordsButton.Name = "removeWordsButton";
            this.removeWordsButton.Size = new System.Drawing.Size(314, 67);
            this.removeWordsButton.TabIndex = 4;
            this.removeWordsButton.Text = "Remove";
            this.removeWordsButton.UseVisualStyleBackColor = true;
            this.removeWordsButton.Click += new System.EventHandler(this.removeWordsButton_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel17.Location = new System.Drawing.Point(0, 69);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(360, 1);
            this.panel17.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(19, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Language";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(15, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Remove Words";
            // 
            // sortPanel
            // 
            this.sortPanel.BackColor = System.Drawing.Color.Transparent;
            this.sortPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sortPanel.Controls.Add(this.sortComboBox);
            this.sortPanel.Controls.Add(this.sortPictureBox);
            this.sortPanel.Controls.Add(this.Sort_Button);
            this.sortPanel.Controls.Add(this.panel16);
            this.sortPanel.Controls.Add(this.label9);
            this.sortPanel.Controls.Add(this.label10);
            this.sortPanel.Location = new System.Drawing.Point(374, 533);
            this.sortPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortPanel.Name = "sortPanel";
            this.sortPanel.Size = new System.Drawing.Size(360, 367);
            this.sortPanel.TabIndex = 0;
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(19, 172);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(313, 29);
            this.sortComboBox.TabIndex = 6;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // sortPictureBox
            // 
            this.sortPictureBox.Location = new System.Drawing.Point(270, 31);
            this.sortPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortPictureBox.Name = "sortPictureBox";
            this.sortPictureBox.Size = new System.Drawing.Size(67, 79);
            this.sortPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sortPictureBox.TabIndex = 5;
            this.sortPictureBox.TabStop = false;
            // 
            // Sort_Button
            // 
            this.Sort_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sort_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_Button.FlatAppearance.BorderSize = 0;
            this.Sort_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sort_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sort_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sort_Button.Location = new System.Drawing.Point(23, 273);
            this.Sort_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.Size = new System.Drawing.Size(314, 67);
            this.Sort_Button.TabIndex = 4;
            this.Sort_Button.Text = "Sort";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel16.Location = new System.Drawing.Point(0, 69);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(360, 1);
            this.panel16.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(19, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Language";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(15, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sort By Language";
            // 
            // githubPictureBox
            // 
            this.githubPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.githubPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubPictureBox.Location = new System.Drawing.Point(1393, 67);
            this.githubPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.githubPictureBox.Name = "githubPictureBox";
            this.githubPictureBox.Size = new System.Drawing.Size(74, 88);
            this.githubPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.githubPictureBox.TabIndex = 1;
            this.githubPictureBox.TabStop = false;
            this.githubPictureBox.Click += new System.EventHandler(this.githubPictureBox_Click);
            // 
            // exitApplicationButton
            // 
            this.exitApplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitApplicationButton.FlatAppearance.BorderSize = 0;
            this.exitApplicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitApplicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApplicationButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitApplicationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitApplicationButton.Location = new System.Drawing.Point(1433, 4);
            this.exitApplicationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitApplicationButton.Name = "exitApplicationButton";
            this.exitApplicationButton.Size = new System.Drawing.Size(39, 44);
            this.exitApplicationButton.TabIndex = 2;
            this.exitApplicationButton.Text = "x";
            this.exitApplicationButton.UseVisualStyleBackColor = false;
            this.exitApplicationButton.Click += new System.EventHandler(this.exitApplicationButton_Click);
            // 
            // minimizeApplicationButton
            // 
            this.minimizeApplicationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minimizeApplicationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeApplicationButton.FlatAppearance.BorderSize = 0;
            this.minimizeApplicationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizeApplicationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeApplicationButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeApplicationButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizeApplicationButton.Location = new System.Drawing.Point(1389, 4);
            this.minimizeApplicationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minimizeApplicationButton.Name = "minimizeApplicationButton";
            this.minimizeApplicationButton.Size = new System.Drawing.Size(41, 44);
            this.minimizeApplicationButton.TabIndex = 2;
            this.minimizeApplicationButton.Text = "_";
            this.minimizeApplicationButton.UseVisualStyleBackColor = false;
            this.minimizeApplicationButton.Click += new System.EventHandler(this.minimizeApplicationButton_Click);
            // 
            // fileLoadedLabel
            // 
            this.fileLoadedLabel.AutoSize = true;
            this.fileLoadedLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileLoadedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileLoadedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileLoadedLabel.Location = new System.Drawing.Point(7, 67);
            this.fileLoadedLabel.Name = "fileLoadedLabel";
            this.fileLoadedLabel.Size = new System.Drawing.Size(146, 23);
            this.fileLoadedLabel.TabIndex = 0;
            this.fileLoadedLabel.Text = "No list loaded";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel13.Controls.Add(this.exitApplicationButton);
            this.panel13.Controls.Add(this.minimizeApplicationButton);
            this.panel13.Controls.Add(this.label14);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1475, 59);
            this.panel13.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(14, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Glossery";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.ForestGreen;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(7, 807);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(360, 93);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputTxtBox.Location = new System.Drawing.Point(8, 160);
            this.outputTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputTxtBox.Multiline = true;
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTxtBox.Size = new System.Drawing.Size(726, 367);
            this.outputTxtBox.TabIndex = 7;
            this.outputTxtBox.TabStop = false;
            this.outputTxtBox.Text = resources.GetString("outputTxtBox.Text");
            this.outputTxtBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // practicePanel
            // 
            this.practicePanel.BackColor = System.Drawing.Color.Firebrick;
            this.practicePanel.Controls.Add(this.label12);
            this.practicePanel.Controls.Add(this.panel21);
            this.practicePanel.Controls.Add(this.label15);
            this.practicePanel.Controls.Add(this.exitPractice);
            this.practicePanel.Controls.Add(this.startPractice);
            this.practicePanel.Controls.Add(this.checkPracticeWord);
            this.practicePanel.Controls.Add(this.practiceTxtBox);
            this.practicePanel.Controls.Add(this.showWords);
            this.practicePanel.Controls.Add(this.panel20);
            this.practicePanel.Location = new System.Drawing.Point(7, 535);
            this.practicePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.practicePanel.Name = "practicePanel";
            this.practicePanel.Size = new System.Drawing.Size(359, 264);
            this.practicePanel.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(17, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Translate";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel21.Location = new System.Drawing.Point(0, 68);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(360, 1);
            this.panel21.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(15, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 32);
            this.label15.TabIndex = 13;
            this.label15.Text = "Practice";
            // 
            // exitPractice
            // 
            this.exitPractice.BackColor = System.Drawing.Color.Transparent;
            this.exitPractice.Enabled = false;
            this.exitPractice.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.exitPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitPractice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitPractice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exitPractice.Location = new System.Drawing.Point(15, 205);
            this.exitPractice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitPractice.Name = "exitPractice";
            this.exitPractice.Size = new System.Drawing.Size(98, 41);
            this.exitPractice.TabIndex = 12;
            this.exitPractice.Text = "Exit";
            this.exitPractice.UseVisualStyleBackColor = false;
            this.exitPractice.Click += new System.EventHandler(this.exitPractice_Click);
            // 
            // startPractice
            // 
            this.startPractice.BackColor = System.Drawing.Color.Transparent;
            this.startPractice.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.startPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPractice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startPractice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startPractice.Location = new System.Drawing.Point(129, 205);
            this.startPractice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startPractice.Name = "startPractice";
            this.startPractice.Size = new System.Drawing.Size(98, 41);
            this.startPractice.TabIndex = 12;
            this.startPractice.Text = "Start";
            this.startPractice.UseVisualStyleBackColor = false;
            this.startPractice.Click += new System.EventHandler(this.startPractice_Click);
            // 
            // checkPracticeWord
            // 
            this.checkPracticeWord.BackColor = System.Drawing.Color.Transparent;
            this.checkPracticeWord.Enabled = false;
            this.checkPracticeWord.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.checkPracticeWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPracticeWord.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkPracticeWord.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkPracticeWord.Location = new System.Drawing.Point(246, 205);
            this.checkPracticeWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkPracticeWord.Name = "checkPracticeWord";
            this.checkPracticeWord.Size = new System.Drawing.Size(98, 41);
            this.checkPracticeWord.TabIndex = 12;
            this.checkPracticeWord.Text = "Check";
            this.checkPracticeWord.UseVisualStyleBackColor = false;
            this.checkPracticeWord.Click += new System.EventHandler(this.checkPracticeWord_Click);
            // 
            // practiceTxtBox
            // 
            this.practiceTxtBox.BackColor = System.Drawing.Color.Firebrick;
            this.practiceTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.practiceTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.practiceTxtBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.practiceTxtBox.Location = new System.Drawing.Point(21, 155);
            this.practiceTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.practiceTxtBox.Name = "practiceTxtBox";
            this.practiceTxtBox.Size = new System.Drawing.Size(342, 20);
            this.practiceTxtBox.TabIndex = 11;
            this.practiceTxtBox.Text = "Enter word";
            this.practiceTxtBox.Enter += new System.EventHandler(this.control_Enter);
            // 
            // showWords
            // 
            this.showWords.AutoSize = true;
            this.showWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showWords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showWords.Location = new System.Drawing.Point(17, 113);
            this.showWords.Name = "showWords";
            this.showWords.Size = new System.Drawing.Size(60, 24);
            this.showWords.TabIndex = 9;
            this.showWords.Text = "Word";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel20.Location = new System.Drawing.Point(21, 184);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(314, 1);
            this.panel20.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1475, 908);
            this.Controls.Add(this.practicePanel);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.githubPictureBox);
            this.Controls.Add(this.sortPanel);
            this.Controls.Add(this.fileLoadedLabel);
            this.Controls.Add(this.removePanel);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createPictureBox)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addPictureBox)).EndInit();
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadPictureBox)).EndInit();
            this.removePanel.ResumeLayout(false);
            this.removePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removePictureBox)).EndInit();
            this.sortPanel.ResumeLayout(false);
            this.sortPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.githubPictureBox)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.practicePanel.ResumeLayout(false);
            this.practicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox createListFileNameTxtBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.PictureBox createPictureBox;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.PictureBox addPictureBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addWordsTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.PictureBox loadPictureBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel removePanel;
        private System.Windows.Forms.PictureBox removePictureBox;
        private System.Windows.Forms.Button removeWordsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel sortPanel;
        private System.Windows.Forms.PictureBox sortPictureBox;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox createListLanguageTxtBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox githubPictureBox;
        private System.Windows.Forms.Button exitApplicationButton;
        private System.Windows.Forms.Button minimizeApplicationButton;
        private System.Windows.Forms.Label fileLoadedLabel;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox outputTxtBox;
        private System.Windows.Forms.Panel practicePanel;
        private System.Windows.Forms.TextBox practiceTxtBox;
        private System.Windows.Forms.Label showWords;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button exitPractice;
        private System.Windows.Forms.Button startPractice;
        private System.Windows.Forms.Button checkPracticeWord;
        private System.Windows.Forms.CheckedListBox removeWordsCheckedListBox;
        private System.Windows.Forms.ComboBox removeFromLangComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ar;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ComboBox loadFNComboBox;
    }
}

