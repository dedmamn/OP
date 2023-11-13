using ClassLibrary;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            colorDialog1.Color = wordBox.ForeColor;
        }

        private void btnAddWithoutParam_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            richTextBox1.SelectionColor = word.Color;
            richTextBox1.AppendText(word.Content + '\n');
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word word = new Word(wordBox.Text.ToString(), colorDialog1.Color);
            richTextBox1.SelectionColor = word.Color;
            richTextBox1.AppendText(word.Content + '\n');
            wordBox.Text = "";
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