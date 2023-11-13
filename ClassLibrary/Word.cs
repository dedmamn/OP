using System.Drawing;

namespace ClassLibrary
{
    public class Word
    {
        public Color Color;
        public string? Content { get; set; }
        public static readonly Color BackColor;

        // Конструкторы
        public Word(string content, Color color)
        {
            this.Content = content;
            this.Color = color;
        }
        public Word(string content)
        {
            this.Content = content;
        }
        public Word() : this("Word", Color.Red) { }
        static Word()
        {
            DateTime now = DateTime.Now;

            if (now.Hour >= 0 && now.Hour < 12)
                Word.BackColor = Color.BlueViolet;
            else
                Word.BackColor = Color.Aquamarine;

        }
    }

    public struct Structure
    {
        public Word word;
        public Color backColor;
        public Font formFont;

        public Structure()
        {
            this.word = new Word();
            this.backColor = Word.BackColor;
            this.formFont = new Font("Arial", 12, FontStyle.Bold);
        }

        public Structure(string font)
        {
            this.word = new Word();
            this.backColor = Word.BackColor;
            this.formFont = new Font(font, 12, FontStyle.Bold);
        }
    }
}
