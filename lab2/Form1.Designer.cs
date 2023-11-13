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
            colorDialog1 = new ColorDialog();
            btnAddWithoutParam = new Button();
            btnWordColor = new Button();
            btnClearRich = new Button();
            btnColored = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBoxNumber = new TextBox();
            listBox1 = new ListBox();
            btnItemColor = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnClearRich.Location = new Point(567, 461);
            btnClearRich.Name = "btnClearRich";
            btnClearRich.Size = new Size(150, 46);
            btnClearRich.TabIndex = 18;
            btnClearRich.Text = "Очистить";
            btnClearRich.UseVisualStyleBackColor = true;
            btnClearRich.Click += btnClearRich_Click;
            // 
            // btnColored
            // 
            btnColored.Location = new Point(20, 444);
            btnColored.Name = "btnColored";
            btnColored.Size = new Size(231, 63);
            btnColored.TabIndex = 19;
            btnColored.Text = "Покрасить форму";
            btnColored.UseVisualStyleBackColor = true;
            btnColored.Click += btnColored_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 219);
            label3.Name = "label3";
            label3.Size = new Size(65, 32);
            label3.TabIndex = 20;
            label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(29, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(471, 39);
            dateTimePicker1.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 357);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(900, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 25;
            label4.Text = "Дата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(900, 31);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 27;
            label5.Text = "Номер";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(900, 82);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(89, 39);
            textBoxNumber.TabIndex = 26;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(567, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(300, 356);
            listBox1.TabIndex = 28;
            // 
            // btnItemColor
            // 
            btnItemColor.Enabled = false;
            btnItemColor.Location = new Point(900, 322);
            btnItemColor.Name = "btnItemColor";
            btnItemColor.Size = new Size(65, 65);
            btnItemColor.TabIndex = 29;
            btnItemColor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(900, 279);
            label6.Name = "label6";
            label6.Size = new Size(143, 32);
            label6.TabIndex = 30;
            label6.Text = "Цвет текста";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1331, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1331, 31);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 32;
            label7.Text = "Картинка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(1331, 452);
            button1.Name = "button1";
            button1.Size = new Size(228, 46);
            button1.TabIndex = 33;
            button1.Text = "Выбор картинки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpenFile_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(900, 212);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(405, 39);
            dateTimePicker2.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1716, 558);
            Controls.Add(dateTimePicker2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnItemColor);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBoxNumber);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(btnColored);
            Controls.Add(btnClearRich);
            Controls.Add(btnWordColor);
            Controls.Add(btnAddWithoutParam);
            Controls.Add(btnAddWord);
            Controls.Add(wordBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private ColorDialog colorDialog1;
        private Button btnAddWithoutParam;
        private Button btnWordColor;
        private Button btnClearRich;
        private Button btnColored;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Label label5;
        private TextBox textBoxNumber;
        private ListBox listBox1;
        private Button btnItemColor;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
    }
}