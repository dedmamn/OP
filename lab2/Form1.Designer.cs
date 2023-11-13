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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            btnAddWithoutParam = new Button();
            btnWordColor = new Button();
            btnClearRich = new Button();
            btnColored = new Button();
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
            wordBox.Location = new Point(20, 81);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(296, 39);
            wordBox.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(567, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(318, 273);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
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
            label2.Location = new Point(567, 30);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 12;
            label2.Text = "Слова";
            // 
            // btnAddWithoutParam
            // 
            btnAddWithoutParam.Location = new Point(330, 136);
            btnAddWithoutParam.Name = "btnAddWithoutParam";
            btnAddWithoutParam.Size = new Size(192, 62);
            btnAddWithoutParam.TabIndex = 16;
            btnAddWithoutParam.Text = "ДобавитьTest";
            btnAddWithoutParam.UseVisualStyleBackColor = true;
            btnAddWithoutParam.Click += btnAddWithoutParam_Click;
            // 
            // btnWordColor
            // 
            btnWordColor.Location = new Point(20, 144);
            btnWordColor.Name = "btnWordColor";
            btnWordColor.Size = new Size(150, 46);
            btnWordColor.TabIndex = 17;
            btnWordColor.Text = "Цвет";
            btnWordColor.UseVisualStyleBackColor = true;
            btnWordColor.Click += btnWordColor_Click;
            // 
            // btnClearRich
            // 
            btnClearRich.Location = new Point(567, 358);
            btnClearRich.Name = "btnClearRich";
            btnClearRich.Size = new Size(150, 46);
            btnClearRich.TabIndex = 18;
            btnClearRich.Text = "Очистить";
            btnClearRich.UseVisualStyleBackColor = true;
            btnClearRich.Click += btnClearRich_Click;
            // 
            // btnColored
            // 
            btnColored.Location = new Point(20, 341);
            btnColored.Name = "btnColored";
            btnColored.Size = new Size(231, 63);
            btnColored.TabIndex = 19;
            btnColored.Text = "Покрасить форму";
            btnColored.UseVisualStyleBackColor = true;
            btnColored.Click += btnColored_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 425);
            Controls.Add(btnColored);
            Controls.Add(btnClearRich);
            Controls.Add(btnWordColor);
            Controls.Add(btnAddWithoutParam);
            Controls.Add(btnAddWord);
            Controls.Add(wordBox);
            Controls.Add(richTextBox1);
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
        private RichTextBox richTextBox1;
        private Label label1;
        private Button btnClearSentence;
        private Label label2;
        private ColorDialog colorDialog1;
        private Button btnAddWithoutParam;
        private Button btnWordColor;
        private Button btnClearRich;
        private Button btnColored;
    }
}