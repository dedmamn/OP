using System;
using System.Drawing;

namespace ClassLibrary
{
    public class Word
    {
        public Color Color;
        public string Content { get; set; }

        public Word(string content, Color color )
        {
            Content = content;
            this.Color = color;
        }
    }
}