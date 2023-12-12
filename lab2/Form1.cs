using ClassLibrary;
using System.ComponentModel;
using System.Diagnostics;

using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab2
{
    public partial class Form1 : Form
    {
        public WordList wordList = new WordList(new List<Word>());
        public SentenceList sentenceList = new SentenceList(new List<Sentence>());

        public Form1()
        {
            InitializeComponent();
            colorDialogWord.AllowFullOpen = false;
            colorDialogWord.ShowHelp = true;
            colorDialogWord.Color = wordBox.ForeColor;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm:ss";

            listBoxWords.SelectionMode = SelectionMode.MultiExtended;
            listBoxWords.DataSource = wordList.Words;
            listBoxWords.DisplayMember = "Content";
            listBoxWords.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxWords.DrawItem += ListBox1_DrawItem;
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

                    // ���������, ��� ���������� .txt �����������
                    if (!filePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        filePath = Path.ChangeExtension(filePath, ".txt");
                    }

                    wordList.WriteWordListToFile(filePath);
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

                    // �������� ����� ReadWordListFromFile, ������� ���� � ���������� �����
                    wordList.ReadWordListFromFile(filePath);
                }
            }
            updateDataSource(listBoxWords);
        }


        /* ��� ������ ��� ����������� ��������� ���������� ���� �� ������*/
        public string FormatDays(int days)
        {
            switch (days)
            {
                case 0:
                    return "�������";
                case 1:
                    return "������";
                case -1:
                    return "�����";
                default:
                    if (days > 1)
                    {
                        return $"����� {days} {GetDayWord(days)}";
                    }
                    else // days < -1
                    {
                        return $"{Math.Abs(days)} {GetDayWord(days)} �����";
                    }
            }
        }

        private string GetDayWord(int days)
        {
            days = Math.Abs(days) % 100;
            int lastDigit = days % 10;

            if (days > 10 && days < 20) return "����";
            if (lastDigit > 1 && lastDigit < 5) return "���";
            if (lastDigit == 1) return "����";
            return "����";
        }
        /* ����� */

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string content = wordBox.Text;
            Color color = wordBox.ForeColor;
            DateTime dateTime = dateTimePicker1.Value;

            Word newWord = new Word(content, color, dateTime);

            wordList.Words.Add(newWord);
            clearBox(wordBox);
            updateDataSource(listBoxWords);

        }

        // ������� textBox
        private void clearBox(TextBox textBox)
        {
            textBox.Text = string.Empty;
            textBox.ForeColor = Color.Black;
            dateTimePicker1.Value = DateTime.Now;
        }

        // ���������� listBox
        private void updateDataSource(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.DataSource = wordList.Words;
            listBox.DisplayMember = "Content";
        }

        private void updateDataSourceSen(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.DataSource = sentenceList.Sentences;
            listBox.DisplayMember = "str";
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

        private void btnClearListWord_Click(object sender, EventArgs e)
        {
            wordList.Words.Clear();
            updateDataSource(listBoxWords);
        }

        private void btnUpstreamWords_Click(object sender, EventArgs e)
        {
            List<Word> selectedWords = listBoxWords.SelectedItems.Cast<Word>().ToList();

            if (selectedWords.Count > 0)
            {
                Sentence sentence = new Sentence(selectedWords);

                foreach (Word selectedWord in selectedWords)
                {
                    wordList.Words.Remove(selectedWord);
                }

                updateDataSource(listBoxWords);

                sentenceList.Sentences.Add(sentence);

                updateDataSourceSen(listBoxSentences);
            }
        }



        private void btnDownstreamWord_Click(object sender, EventArgs e)
        {
            if (listBoxSentences.SelectedItems != null)
            {
                Sentence selectedSentence = listBoxSentences.SelectedItem as Sentence;

                if (selectedSentence != null)
                {
                    wordList.Words.Clear();

                    foreach (Word word in selectedSentence.Content)
                    {
                        Word newWord = new Word(word.Content, word.Color, word.WriteDate);

                        wordList.Words.Add(newWord);
                    }

                    updateDataSource(listBoxWords);
                }
            }
        }

        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedItem != null)
            {
                Word selectedWord = (Word)listBoxWords.SelectedItem;
                labelWordLength.Text = $"����� �����: {selectedWord.GetLength()} ��������";
            }
        }

        private void listBoxSentences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSentences.SelectedItem != null)
            {
                Sentence selectedSentece = (Sentence)listBoxSentences.SelectedItem;
                labelSentenceLength.Text = $"����� �����������: {selectedSentece.GetLength()} ����";
            }
        }
    }
}