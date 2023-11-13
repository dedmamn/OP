using System.Drawing;

namespace ClassLibrary
{
    public class WordV3
    {
        public Color color { get { return color; } set { color = value; } }
        public string? content;
        public string? Content {
            get 
            { 
                return content;
            }
            set 
            { 
                if (value == "") { content = "Пустое"; }
            }
        }

        public static readonly Color BackColor;

        
        

        // Конструкторы
        public WordV3(string content, Color color)
        {
            this.content = content;
            this.color = color;
        }
        public WordV3(string content)
        {
            this.content = content;
        }
        public WordV3() : this("WordV2", Color.Red) { }
        static WordV3()
        {
            DateTime now = DateTime.Now;

            if (now.Hour >= 0 && now.Hour < 12)
                WordV3.BackColor = Color.BlueViolet;
            else
                WordV3.BackColor = Color.Aquamarine;

        }
    }

    public struct StructureV3
    {
        public WordV2 word;
        public Color backColor;
        public Font formFont;

        public StructureV3()
        {
            this.word = new WordV2();
            this.backColor = WordV2.BackColor;
            this.formFont = new Font("Arial", 12, FontStyle.Bold);
        }

        public StructureV3(string font)
        {
            this.word = new WordV2();
            this.backColor = WordV2.BackColor;
            this.formFont = new Font(font, 12, FontStyle.Bold);
        }
    }
}
