using ClassLibrary;
using System.Windows.Forms;

namespace lab1
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

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            Word word = new Word(wordBox.Text, colorDialog1.Color);
            richTextBox1.SelectionColor = word.Color;
            richTextBox1.AppendText(word.Content + '\n');
            wordBox.Text = "";
        }

        private void btnClearSentence_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnColorWord_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            wordBox.ForeColor = colorDialog1.Color;
        }

    }
}