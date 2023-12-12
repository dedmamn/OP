using ClassLibrary;
using System.Drawing;


namespace lab2
{
    public class Word : TextElement
    {
         
        public Color Color { get; set; }
        public DateTime WriteDate { get; set; }
        public string? FilePath {  get; set; }

        // Конструктор
        public Word() { }
        public Word(string content, Color color, DateTime? dateTime = null, string? filePath = null) : base(content)
        {
            Color = color;
            WriteDate = dateTime ?? DateTime.Now;
        }

        // Запись в файл
        public override void WriteToFile(string path)
        {
            if (path != null)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine($"Content: {Content}, Color: {Color.ToArgb()}, WriteDate: {WriteDate}");
                }
                FilePath = path;
            }
        }

        // Чтение из файла
        public override TextElement? CreateFromFile(string path)
        {
            if (path != null)
            {
                string line = ReadLineFromFile(path);
                if (line != null)
                {
                    FilePath = path;
                    return CreateWordFromLine(line);
                }
            }
            return null;
        }

        private string ReadLineFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadLine();
            }
        }

        public static Word CreateWordFromLine(string line)
        {
            string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            string contentPart = parts.FirstOrDefault(p => p.StartsWith("Content:"));
            string colorPart = parts.FirstOrDefault(p => p.StartsWith("Color:"));
            string datePart = parts.FirstOrDefault(p => p.StartsWith("WriteDate:"));

            string content = contentPart?.Split(new string[] { ": " }, StringSplitOptions.None)[1];
            int colorArgb;
            if (int.TryParse(colorPart?.Split(new string[] { ": " }, StringSplitOptions.None)[1], out colorArgb))
            {
                Color color = Color.FromArgb(colorArgb);
                DateTime writeDate;
                string dateString = datePart?.Split(new string[] { ": " }, StringSplitOptions.None)[1];

                if (!DateTime.TryParse(dateString, out writeDate))
                {
                    writeDate = DateTime.Now;
                }
                return new Word(content, color, writeDate);
            }
            return null;
        }

        public int ClalculateDays()
        {
            return (WriteDate.Date - DateTime.Now.Date).Days;
        }

        public int ClalculateDays(DateTime dateTime)
        {
            return (WriteDate.Date -  dateTime.Date).Days;
        }

        public int GetLength()
        {
            if (Content != null)
            {
                return Content.Length;
            }
            else return 0;
            
        }

        public void CapitalizeFirstLetter()
        {
            if (!string.IsNullOrEmpty(Content))
            {
                Content = char.ToUpper(Content[0]) + Content.Substring(1);
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Write Date: {WriteDate}");
            Console.WriteLine($"Length: {GetLength()} characters");
        }
    }

}