namespace lab3
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
            btnColored = new Button();
            btnClearRich = new Button();
            btnWordColor = new Button();
            btnAddWithoutParam = new Button();
            btnAddWord = new Button();
            wordBox = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnColored
            // 
            btnColored.Location = new Point(70, 403);
            btnColored.Name = "btnColored";
            btnColored.Size = new Size(231, 63);
            btnColored.TabIndex = 28;
            btnColored.Text = "Покрасить форму";
            btnColored.UseVisualStyleBackColor = true;
            // 
            // btnClearRich
            // 
            btnClearRich.Location = new Point(617, 420);
            btnClearRich.Name = "btnClearRich";
            btnClearRich.Size = new Size(150, 46);
            btnClearRich.TabIndex = 27;
            btnClearRich.Text = "Очистить";
            btnClearRich.UseVisualStyleBackColor = true;
            // 
            // btnWordColor
            // 
            btnWordColor.Location = new Point(70, 206);
            btnWordColor.Name = "btnWordColor";
            btnWordColor.Size = new Size(150, 46);
            btnWordColor.TabIndex = 26;
            btnWordColor.Text = "Цвет";
            btnWordColor.UseVisualStyleBackColor = true;
            // 
            // btnAddWithoutParam
            // 
            btnAddWithoutParam.Location = new Point(380, 198);
            btnAddWithoutParam.Name = "btnAddWithoutParam";
            btnAddWithoutParam.Size = new Size(192, 62);
            btnAddWithoutParam.TabIndex = 25;
            btnAddWithoutParam.Text = "ДобавитьTest";
            btnAddWithoutParam.UseVisualStyleBackColor = true;
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(400, 139);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(150, 46);
            btnAddWord.TabIndex = 20;
            btnAddWord.Text = "Добавить";
            btnAddWord.UseVisualStyleBackColor = true;
            // 
            // wordBox
            // 
            wordBox.Location = new Point(70, 143);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(296, 39);
            wordBox.TabIndex = 21;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(617, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(318, 273);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 93);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 22;
            label1.Text = "Слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 92);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 23;
            label2.Text = "Слова";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 548);
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

        private Button btnColored;
        private Button btnClearRich;
        private Button btnWordColor;
        private Button btnAddWithoutParam;
        private Button btnAddWord;
        private TextBox wordBox;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
    }
}