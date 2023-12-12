using lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct WordList
    {
        public List<Word> Words { get; set; }

        public WordList(List<Word> words)
        {
            Words = words;
        }

        public void WriteWordListToFile(string path)
        {
            if (Words == null || Words.Count == 0 || string.IsNullOrEmpty(path))
            {
                return;
            }

            foreach (Word word in Words)
            {
                word.WriteToFile(path);
            }
        }

        public void ReadWordListFromFile(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Читаем каждую строку и создаем объект Word из нее
                        Word word = Word.CreateWordFromLine(line);
                        if (word != null)
                        {
                            Words.Add(word);
                        }
                    }
                }
            }
        }
    }
}
