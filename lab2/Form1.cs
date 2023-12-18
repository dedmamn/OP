using ClassLibrary;
using System.ComponentModel;
using System.Diagnostics;

using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab2
{
    public partial class Form1 : Form
    {
        public WordList wordListBox = new WordList(new List<Word>());
        public SentenceList sentenceList = new SentenceList(new List<Sentence>());

        public Form1()
        {
            InitializeComponent();
            colorDialogWord.AllowFullOpen = false;
            colorDialogWord.ShowHelp = true;
            colorDialogWord.Color = wordBox.ForeColor;

            listBoxWords.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxWords.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
        }


        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Word word = listBoxWords.Items[e.Index] as Word;
            e.DrawBackground();
            using (Brush brush = new SolidBrush(word.Color))
            {
                e.Graphics.DrawString(word.Content, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }


        private void writeToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Проверяем, что расширение .txt установлено
                    if (!filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        filePath = Path.ChangeExtension(filePath, ".txt");
                    }

                    wordListBox.WriteWordListToFile(filePath);
                }
            }
        }


        private void btnReadWord_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    wordListBox.ReadWordListFromFile(filePath);
                }
            }
            updateDataSource(listBoxWords);
        }



        /* Два метода для правильного написания количества дней до записи*/
        /*
        public string FormatDays(int days)
        {
            switch (days)
            {
                case 0:
                    return "сегодня";
                case 1:
                    return "завтра";
                case -1:
                    return "вчера";
                default:
                    if (days > 1)
                    {
                        return $"через {days} {GetDayWord(days)}";
                    }
                    else // days < -1
                    {
                        return $"{Math.Abs(days)} {GetDayWord(days)} назад";
                    }
            }
        }
        */
        /*
        private string GetDayWord(int days)
        {
            days = Math.Abs(days) % 100;
            int lastDigit = days % 10;

            if (days > 10 && days < 20) return "дней";
            if (lastDigit > 1 && lastDigit < 5) return "дня";
            if (lastDigit == 1) return "день";
            return "дней";
        }
        /* Конец */

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string content = wordBox.Text;
            Color color = wordBox.ForeColor;

            Word newWord = new Word(content, color);

            wordListBox.Words.Add(newWord);
            clearBox(wordBox);
            updateDataSource(listBoxWords);

        }

        // Очистка textBox
        private void clearBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.ForeColor = Color.Black;
        }

        // Обновление listBox
        private void updateDataSource(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.DataSource = wordListBox.Words;
            listBox.DisplayMember = "Content";
        }


        private void btnWordColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    wordBox.ForeColor = colorDialog.Color;
                }
            }
        }

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedItem != null)
            {
                Word selectedWord = (Word)listBoxWords.SelectedItem;
                labelList.Text = $"Длина слова: {selectedWord.GetLength()} символов";
            }
        }

        private void DisplayWord(Word word)
        {
            richText.SelectionColor = word.Color;
            richText.AppendText(word.Content + " ");
            richText.SelectionColor = richText.ForeColor; // Возвращаем цвет по умолчанию
        }


        private void btnWordsAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSenAdd_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClearWords_Click(object sender, EventArgs e)
        {
            wordListBox.Words.Clear();
            updateDataSource(listBoxWords);
            labelList.Text = "";
        }
    }
}