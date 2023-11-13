namespace lab1
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
            btnClearSentence = new Button();
            btnColorWord = new Button();
            colorDialog1 = new ColorDialog();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(343, 61);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(150, 46);
            btnAddWord.TabIndex = 0;
            btnAddWord.Text = "Добавить";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // wordBox
            // 
            wordBox.Location = new Point(13, 65);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(296, 39);
            wordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 2;
            label1.Text = "Слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(560, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 3;
            label2.Text = "Слова";
            // 
            // btnClearSentence
            // 
            btnClearSentence.Location = new Point(560, 337);
            btnClearSentence.Name = "btnClearSentence";
            btnClearSentence.Size = new Size(150, 46);
            btnClearSentence.TabIndex = 5;
            btnClearSentence.Text = "Очистить";
            btnClearSentence.UseVisualStyleBackColor = true;
            btnClearSentence.Click += btnClearSentence_Click;
            // 
            // btnColorWord
            // 
            btnColorWord.Location = new Point(13, 128);
            btnColorWord.Name = "btnColorWord";
            btnColorWord.Size = new Size(150, 46);
            btnColorWord.TabIndex = 6;
            btnColorWord.Text = "Цвет";
            btnColorWord.UseVisualStyleBackColor = true;
            btnColorWord.Click += btnColorWord_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(560, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(318, 273);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 421);
            Controls.Add(btnAddWord);
            Controls.Add(wordBox);
            Controls.Add(btnColorWord);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(btnClearSentence);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddWord;
        private TextBox wordBox;
        private Label label1;
        private Label label2;
        private Button btnClearSentence;
        private Button btnColorWord;
        private ColorDialog colorDialog1;
        private RichTextBox richTextBox1;
    }
}