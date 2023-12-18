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
            label1 = new Label();
            btnWordColor = new Button();
            colorDialogWord = new ColorDialog();
            richText = new RichTextBox();
            btnSenAdd = new Button();
            label2 = new Label();
            richSentence = new RichTextBox();
            label3 = new Label();
            menuStrip2 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            statToolStripMenuItem = new ToolStripMenuItem();
            wordBox = new TextBox();
            listBoxWords = new ListBox();
            btnWordsAdd = new Button();
            labelList = new Label();
            btnClearWords = new Button();
            btnReadWords = new Button();
            label4 = new Label();
            textBoxAuthor = new TextBox();
            checkBox1 = new CheckBox();
            btnAuthorSet = new Button();
            button1 = new Button();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(1251, 93);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(152, 50);
            btnAddWord.TabIndex = 9;
            btnAddWord.Text = "Добавить";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += btnAddWord_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(771, 64);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 11;
            label1.Text = "Слово";
            // 
            // btnWordColor
            // 
            btnWordColor.Location = new Point(1098, 93);
            btnWordColor.Name = "btnWordColor";
            btnWordColor.Size = new Size(134, 50);
            btnWordColor.TabIndex = 17;
            btnWordColor.Text = "Цвет";
            btnWordColor.UseVisualStyleBackColor = true;
            btnWordColor.Click += btnWordColor_Click;
            // 
            // richText
            // 
            richText.Location = new Point(27, 100);
            richText.Name = "richText";
            richText.Size = new Size(683, 658);
            richText.TabIndex = 45;
            richText.Text = "";
            // 
            // btnSenAdd
            // 
            btnSenAdd.Location = new Point(1251, 570);
            btnSenAdd.Name = "btnSenAdd";
            btnSenAdd.Size = new Size(152, 50);
            btnSenAdd.TabIndex = 46;
            btnSenAdd.Text = "Добавить";
            btnSenAdd.UseVisualStyleBackColor = true;
            btnSenAdd.Click += btnSenAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(771, 501);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 48;
            label2.Text = "Предложение";
            // 
            // richSentence
            // 
            richSentence.Location = new Point(771, 546);
            richSentence.Name = "richSentence";
            richSentence.Size = new Size(461, 100);
            richSentence.TabIndex = 50;
            richSentence.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 51;
            label3.Text = "Текст";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(32, 32);
            menuStrip2.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1457, 40);
            menuStrip2.TabIndex = 56;
            menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(90, 36);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(263, 44);
            openToolStripMenuItem.Text = "Открыть";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(263, 44);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(184, 36);
            toolsToolStripMenuItem.Text = "Инструменты";
            // 
            // statToolStripMenuItem
            // 
            statToolStripMenuItem.Name = "statToolStripMenuItem";
            statToolStripMenuItem.Size = new Size(267, 44);
            statToolStripMenuItem.Text = "Статистика";
            statToolStripMenuItem.Click += statToolStripMenuItem_Click;
            // 
            // wordBox
            // 
            wordBox.ForeColor = Color.Black;
            wordBox.Location = new Point(771, 99);
            wordBox.Name = "wordBox";
            wordBox.Size = new Size(296, 39);
            wordBox.TabIndex = 10;
            // 
            // listBoxWords
            // 
            listBoxWords.FormattingEnabled = true;
            listBoxWords.ItemHeight = 32;
            listBoxWords.Location = new Point(771, 188);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(296, 228);
            listBoxWords.TabIndex = 57;
            listBoxWords.SelectedIndexChanged += listBoxWords_SelectedIndexChanged;
            // 
            // btnWordsAdd
            // 
            btnWordsAdd.Location = new Point(1080, 356);
            btnWordsAdd.Name = "btnWordsAdd";
            btnWordsAdd.Size = new Size(152, 50);
            btnWordsAdd.TabIndex = 59;
            btnWordsAdd.Text = "Добавить";
            btnWordsAdd.UseVisualStyleBackColor = true;
            btnWordsAdd.Click += btnWordsAdd_Click;
            // 
            // labelList
            // 
            labelList.AutoSize = true;
            labelList.Location = new Point(776, 419);
            labelList.Name = "labelList";
            labelList.Size = new Size(0, 32);
            labelList.TabIndex = 60;
            // 
            // btnClearWords
            // 
            btnClearWords.Location = new Point(1080, 188);
            btnClearWords.Name = "btnClearWords";
            btnClearWords.Size = new Size(152, 50);
            btnClearWords.TabIndex = 61;
            btnClearWords.Text = "Очистить";
            btnClearWords.UseVisualStyleBackColor = true;
            btnClearWords.Click += btnClearWords_Click;
            // 
            // btnReadWords
            // 
            btnReadWords.Location = new Point(1080, 244);
            btnReadWords.Name = "btnReadWords";
            btnReadWords.Size = new Size(152, 50);
            btnReadWords.TabIndex = 62;
            btnReadWords.Text = "Прочитать";
            btnReadWords.UseVisualStyleBackColor = true;
            btnReadWords.Click += btnReadWord_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 579);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 64;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(771, 719);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(322, 39);
            textBoxAuthor.TabIndex = 65;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(771, 666);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 36);
            checkBox1.TabIndex = 66;
            checkBox1.Text = "Автор?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAuthorSet
            // 
            btnAuthorSet.Location = new Point(1114, 713);
            btnAuthorSet.Name = "btnAuthorSet";
            btnAuthorSet.Size = new Size(152, 50);
            btnAuthorSet.TabIndex = 67;
            btnAuthorSet.Text = "Установить";
            btnAuthorSet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1080, 300);
            button1.Name = "button1";
            button1.Size = new Size(152, 50);
            button1.TabIndex = 68;
            button1.Text = "Записать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += writeToFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 784);
            Controls.Add(button1);
            Controls.Add(btnAuthorSet);
            Controls.Add(checkBox1);
            Controls.Add(textBoxAuthor);
            Controls.Add(label4);
            Controls.Add(btnReadWords);
            Controls.Add(btnClearWords);
            Controls.Add(labelList);
            Controls.Add(btnWordsAdd);
            Controls.Add(listBoxWords);
            Controls.Add(label3);
            Controls.Add(richSentence);
            Controls.Add(btnSenAdd);
            Controls.Add(label2);
            Controls.Add(richText);
            Controls.Add(btnWordColor);
            Controls.Add(btnAddWord);
            Controls.Add(wordBox);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddWord;
        private Button btnColorWord;
        private Label label1;
        private Button btnClearSentence;
        private Button btnWordColor;
        private ColorDialog colorDialogWord;
        private RichTextBox richText;
        private Button btnSenAdd;
        private Label label2;
        private RichTextBox richSentence;
        private Label label3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem statToolStripMenuItem;
        private TextBox wordBox;
        private ListBox listBoxWords;
        private Button btnWordsAdd;
        private Label labelList;
        private Button btnClearWords;
        private Button btnReadWords;
        private Label label4;
        private TextBox textBoxAuthor;
        private CheckBox checkBox1;
        private Button btnAuthorSet;
        private Button button1;
    }
}