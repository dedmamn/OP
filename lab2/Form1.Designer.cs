namespace lab2
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
            btnAddWord = new Button();
            wordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnWordColor = new Button();
            btnClearListWord = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            listBoxWords = new ListBox();
            btnReadWord = new Button();
            btnWriteWord = new Button();
            label4 = new Label();
            colorDialogWord = new ColorDialog();
            label5 = new Label();
            btnUpstreamWord = new Button();
            listBoxSentences = new ListBox();
            btnDownstreamWord = new Button();
            labelWordLength = new Label();
            label7 = new Label();
            labelSentenceLength = new Label();
            SuspendLayout();
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(350, 77);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(150, 46);
            btnAddWord.TabIndex = 9;
            btnAddWord.Text = "Добавить";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // wordBox
            // 
            wordBox.ForeColor = Color.Black;
            wordBox.Location = new Point(20, 84);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(296, 39);
            wordBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 31);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 11;
            label1.Text = "Слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 288);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 12;
            label2.Text = "Слова";
            // 
            // btnWordColor
            // 
            btnWordColor.Location = new Point(350, 140);
            btnWordColor.Name = "btnWordColor";
            btnWordColor.Size = new Size(150, 46);
            btnWordColor.TabIndex = 17;
            btnWordColor.Text = "Цвет";
            btnWordColor.UseVisualStyleBackColor = true;
            btnWordColor.Click += btnWordColor_Click;
            // 
            // btnClearListWord
            // 
            btnClearListWord.Location = new Point(356, 281);
            btnClearListWord.Name = "btnClearListWord";
            btnClearListWord.Size = new Size(144, 46);
            btnClearListWord.TabIndex = 18;
            btnClearListWord.Text = "Очистить";
            btnClearListWord.UseVisualStyleBackColor = true;
            btnClearListWord.Click += btnClearListWord_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 154);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 20;
            label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(480, 39);
            dateTimePicker1.TabIndex = 21;
            // 
            // listBoxWords
            // 
            listBoxWords.FormattingEnabled = true;
            listBoxWords.ItemHeight = 32;
            listBoxWords.Location = new Point(20, 339);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(480, 356);
            listBoxWords.TabIndex = 28;
            listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
            // 
            // btnReadWord
            // 
            btnReadWord.Location = new Point(350, 755);
            btnReadWord.Name = "btnReadWord";
            btnReadWord.Size = new Size(150, 46);
            btnReadWord.TabIndex = 35;
            btnReadWord.Text = "Прочитать";
            btnReadWord.UseVisualStyleBackColor = true;
            btnReadWord.Click += btnReadWord_Click;
            // 
            // btnWriteWord
            // 
            btnWriteWord.Location = new Point(20, 755);
            btnWriteWord.Name = "btnWriteWord";
            btnWriteWord.Size = new Size(144, 46);
            btnWriteWord.TabIndex = 36;
            btnWriteWord.Text = "Записать";
            btnWriteWord.UseVisualStyleBackColor = true;
            btnWriteWord.Click += writeToFile_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 295);
            label4.Name = "label4";
            label4.Size = new Size(169, 32);
            label4.TabIndex = 38;
            label4.Text = "Предложения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1111, 31);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 39;
            // 
            // btnUpstreamWord
            // 
            btnUpstreamWord.Location = new Point(506, 445);
            btnUpstreamWord.Name = "btnUpstreamWord";
            btnUpstreamWord.Size = new Size(69, 43);
            btnUpstreamWord.TabIndex = 40;
            btnUpstreamWord.Text = "->";
            btnUpstreamWord.UseVisualStyleBackColor = true;
            btnUpstreamWord.Click += btnUpstreamWords_Click;
            // 
            // listBoxSentences
            // 
            listBoxSentences.FormattingEnabled = true;
            listBoxSentences.ItemHeight = 32;
            listBoxSentences.Location = new Point(581, 339);
            listBoxSentences.Name = "listBoxSentences";
            listBoxSentences.Size = new Size(483, 356);
            listBoxSentences.TabIndex = 41;
            listBoxSentences.SelectedIndexChanged += listBoxSentences_SelectedIndexChanged;
            // 
            // btnDownstreamWord
            // 
            btnDownstreamWord.Location = new Point(506, 509);
            btnDownstreamWord.Name = "btnDownstreamWord";
            btnDownstreamWord.Size = new Size(69, 43);
            btnDownstreamWord.TabIndex = 42;
            btnDownstreamWord.Text = "<-";
            btnDownstreamWord.UseVisualStyleBackColor = true;
            btnDownstreamWord.Click += btnDownstreamWord_Click;
            // 
            // labelWordLength
            // 
            labelWordLength.AutoSize = true;
            labelWordLength.Location = new Point(20, 709);
            labelWordLength.Name = "labelWordLength";
            labelWordLength.Size = new Size(166, 32);
            labelWordLength.TabIndex = 43;
            labelWordLength.Text = "Длина слова: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(665, 869);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 44;
            label7.Text = "label7";
            // 
            // labelSentenceLength
            // 
            labelSentenceLength.AutoSize = true;
            labelSentenceLength.Location = new Point(581, 709);
            labelSentenceLength.Name = "labelSentenceLength";
            labelSentenceLength.Size = new Size(255, 32);
            labelSentenceLength.TabIndex = 46;
            labelSentenceLength.Text = "Длина предложения: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 879);
            Controls.Add(labelSentenceLength);
            Controls.Add(label7);
            Controls.Add(labelWordLength);
            Controls.Add(btnDownstreamWord);
            Controls.Add(listBoxSentences);
            Controls.Add(btnUpstreamWord);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnWriteWord);
            Controls.Add(btnReadWord);
            Controls.Add(listBoxWords);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(btnClearListWord);
            Controls.Add(btnWordColor);
            Controls.Add(btnAddWord);
            Controls.Add(wordBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddWord;
        private TextBox wordBox;
        private Button btnColorWord;
        private Label label1;
        private Button btnClearSentence;
        private Label label2;
        private Button btnWordColor;
        private Button btnClearListWord;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ListBox listBoxWords;
        private Button btnReadWord;
        private Button btnWriteWord;
        private Label label4;
        private ColorDialog colorDialogWord;
        private Label label5;
        private Button btnUpstreamWord;
        private ListBox listBoxSentences;
        private Button btnDownstreamWord;
        private Label labelWordLength;
        private Label label7;
        private Label labelSentenceLength;
    }
}