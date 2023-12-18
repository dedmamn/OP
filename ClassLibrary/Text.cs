using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Text : TextElement
    {
        private string Caption {  get; set; }
        private string Author { get; set; }

        private DateTime WriteDate { get; set; }

        private string Topic { get; set; }

        private List<Sentence> Sentences { get; set; }

        private void Trim()
        {

        }

        private void GetLength()
        {

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
