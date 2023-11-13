using ClassLibrary;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Structure structure;
        public Form1()
        {
            InitializeComponent();
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            colorDialog1.Color = wordBox.ForeColor;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm:ss";
            numericUpDown1.Value = 1;
            structure = new Structure(dateTimePicker1.Value);
        }

        private void btnAddWithoutParam_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            richTextBox1.SelectionColor = word.Color;
            richTextBox1.AppendText(word.Content + '\n');
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word word = new Word(wordBox.Text.ToString(), colorDialog1.Color, (int)numericUpDown1.Value);
            richTextBox1.SelectionColor = word.Color;
            structure.writeDate = dateTimePicker1.Value;
            // ƒобавление даты к слову перед его выводом
            richTextBox1.AppendText(word.Number.ToString() + " - " + word.Content + "  " + structure.writeDate.ToString() + '\n');
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
            richTextBox1.Clear();
        }

        private void btnColored_Click(object sender, EventArgs e)
        {
            Structure structure = new Structure()
            {
                backColor = colorDialog1.Color
            };

            structure = new Structure();

            this.BackColor = structure.backColor;
            this.Font = structure.formFont;
            richTextBox1.SelectionColor = structure.word.Color;
            richTextBox1.AppendText(structure.word.Content + '\n');
        }
    }
}