using System.Drawing;

namespace ClassLibrary
{
    public class Word
    {
        public Color Color { get; set; }
        private string _content;
        public int Number { get; set; }

        public string Content
        {
            get => _content;
            set
            {
                if (!string.IsNullOrEmpty(value) && char.IsLower(value[0]))
                {
                    value = char.ToUpper(value[0]) + value.Substring(1);
                }
                _content = value;
            }
        }

        public static readonly Color BackColor;


        // Конструкторы
        public Word(string content, Color color, int number)
        {
            this.Content = content;
            this.Color = color;
            this.Number = number;
        }
        public Word(string content)
        {
            this.Content = content;
        }
        public Word() : this("Word", Color.Red, 1) { }
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
        public DateTime writeDate;
        public Color backColor;
        public Font formFont = new Font("Segoe UI", 9, FontStyle.Regular);

        public Structure()
        {
            this.word = new Word();
            this.writeDate = DateTime.Now;
            this.backColor = Word.BackColor;
            this.formFont = new Font("Arial", 12, FontStyle.Bold);
        }

        public Structure(string font)
        {
            this.word = new Word();
            this.writeDate = DateTime.Now;
            this.backColor = Word.BackColor;
            this.formFont = new Font(font, 12, FontStyle.Bold);
        }

        public Structure(DateTime dateTime)
        {
            this.word = new Word();
            this.backColor = Word.BackColor;
            this.writeDate = dateTime;
        }
    }
}
