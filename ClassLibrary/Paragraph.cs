using lab2;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibrary
{
    public class Paragraph : TextElement
    {
        private new List<Sentence> Content { get; set; }

        public Paragraph(List<Sentence> sentences)
        {
            Content = sentences;
        }

        public override TextElement? CreateFromFile(string path)
        {
            throw new NotImplementedException();
        }

        public override void WriteToFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
