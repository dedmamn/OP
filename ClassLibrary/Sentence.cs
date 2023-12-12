using lab2;
using System.Text;

namespace ClassLibrary
{
    public class Sentence : Word
    {
        public new List<Word> Content { get; set; }
        public string str
        {
            get { return ToString(); }
            set { str = value; }
        }

        public Sentence(List<Word> content)
        {
            Content = content;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Word word in Content)
            {
                sb.Append(word.Content);

                if (word != Content.Last()) // Проверяем, не последнее ли это слово
                {
                    sb.Append(" "); // Добавляем пробел, если это не последнее слово
                }
            }

            return sb.ToString();
        }

        public new int GetLength()
        {
            return Content.Count;
        }

        public new void PrintDetails()
        {
            base.PrintDetails(); // Вызываем метод PrintDetails из базового класса (Word)
            Console.WriteLine($"Word Count: {GetLength()} words");
        }
    }
}
