using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Word
    {
        public Color Color { get; set; }
        private string _content;
        public int Number { get; set; }
        private string foto { get; set; }
        public DateTime writeDate {  get; set; }
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

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
            this.writeDate = DateTime.Now;
        }
        public Word(string content, Color color, int number, DateTime dateTime)
        {
            this.Content = content;
            this.Color = color;
            this.Number = number;
            this.writeDate = dateTime;
        }
        public Word(string content, Color color, int number, DateTime dateTime, string foto)
        {
            this.Content = content;
            this.Color = color;
            this.Number = number;
            this.writeDate = dateTime;
            this.foto = foto;
        }
        public Word(string content)
        {
            this.writeDate = DateTime.Now;
            this.Content = content;
        }
        public Word(string content, string foto)
        {
            this.writeDate = DateTime.Now;
            this.Content = content;
            this.foto = foto;
        }
        public Word() : this("Word", Color.Red, 1, DateTime.Now, "C:\\Users\\dedman\\Pictures\\kit.jpg") { }
        static Word()
        {
            DateTime now = DateTime.Now;
            if (now.Hour >= 0 && now.Hour < 12)
                Word.BackColor = Color.BlueViolet;
            else
                Word.BackColor = Color.Aquamarine;
        }

        public void WriteToFile(SaveFileDialog saveFileDialog)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine($"Content: {Content}, Number: {Number}, Color: {Color}");
                }
            }
        }

        public void WriteToFile(string filePath)
        {
            if (filePath != null)
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"Content: {Content}, Number: {Number}, Color: {Color}");
                }
            }
        }

        public void ReadFromFile(OpenFileDialog openFileDialog, BindingList<Word> words)
        {
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Парсинг строки и создание объекта Word
                        // Пример строки: "Content: Test, Number: 1, Color: Color [Red]"
                        string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                        string content = parts[0].Split(new string[] { ": " }, StringSplitOptions.None)[1];
                        int number = int.Parse(parts[1].Split(new string[] { ": " }, StringSplitOptions.None)[1]);
                        string colorName = parts[2].Substring(parts[2].IndexOf('[') + 1).TrimEnd(']');

                        Color color = Color.FromName(colorName);
                        Word word = new Word(content, color, number, DateTime.Now);
                        words.Add(word);
                    }
                }
            }
            
        }

        public int ClalculateDays(out int days)
        {
            days = (this.writeDate.Date - DateTime.Now.Date).Days;
            return days;
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

