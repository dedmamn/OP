using ClassLibrary;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Structure structure;
        private BindingList<Word> words;
        public Word word = new Word("����", "C:\\Users\\dedman\\Pictures\\kit.jpg");

        public Form1()
        {
            InitializeComponent();
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            colorDialog1.Color = wordBox.ForeColor;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy hh:mm:ss";

            numericUpDown1.Value = 1;
            structure = new Structure(dateTimePicker1.Value);
            words = new BindingList<Word>();

            listBox1.DataSource = words;
            listBox1.DisplayMember = "Content";
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += ListBox1_DrawItem;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

            pictureBox1.ImageLocation = word.Foto;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ��������� ���� � ���������� �����
                    string filePath = openFileDialog.FileName;

                    // �������� ����������� � ��� ����������� � PictureBox
                    pictureBox1.ImageLocation = filePath;
                }
            }
        }
        
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Word selectedWord = listBox1.SelectedItem as Word;
                if (selectedWord != null)
                {
                    textBoxNumber.Text = selectedWord.Number.ToString();
                    dateTimePicker2.Value = structure.writeDate;
                    btnItemColor.BackColor = selectedWord.Color;
                }
            }
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Word word = listBox1.Items[e.Index] as Word;
            e.DrawBackground();
            using (Brush brush = new SolidBrush(word.Color))
            {
                e.Graphics.DrawString(word.Content, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void btnAddWithoutParam_Click(object sender, EventArgs e)
        {
            words.Add(word);
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word word = new Word(wordBox.Text.ToString(), colorDialog1.Color, (int)numericUpDown1.Value);
            structure.writeDate = dateTimePicker1.Value;
            words.Add(word);
            wordBox.Text = "";
            numericUpDown1.Value += 1;
        }

        private void btnWordColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            wordBox.ForeColor = colorDialog1.Color;
        }

        private void btnClearRich_Click(object sender, EventArgs e)
        {
            words.Clear();
        }

        private void btnColored_Click(object sender, EventArgs e)
        {
            structure = new Structure();

            this.BackColor = structure.backColor;
            this.Font = structure.formFont;
        }
    }
}