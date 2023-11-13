using System.Drawing;

namespace ClassLibrary
{
    public class WordV2
    {
        public Color Color;
        public string? Content { get; set; }
        public static readonly Color BackColor;

        // Конструкторы
        public WordV2(string content, Color color)
        {
            this.Content = content;
            this.Color = color;
        }
        public WordV2(string content)
        {
            this.Content = content;
        }
        public WordV2() : this("WordV2", Color.Red) { }d
        static WordV2()
        {
            DateTime now = DateTime.Now;

            if (now.Hour >= 0 && now.Hour < 12)
                WordV2.BackColor = Color.BlueViolet;
            else
                WordV2.BackColor = Color.Aquamarine;

        }
    }

    public struct Structure
    {
        public WordV2 word;
        public Color backColor;
        public Font formFont;

        public Structure()
        {
            this.word = new WordV2();
            this.backColor = WordV2.BackColor;
            this.formFont = new Font("Arial", 12, FontStyle.Bold);
        }

        public Structure(string font)
        {
            this.word = new WordV2();
            this.backColor = WordV2.BackColor;
            this.formFont = new Font(font, 12, FontStyle.Bold);
        }
    }
}
