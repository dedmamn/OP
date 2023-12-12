using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct SentenceList
    {
        public List<Sentence> Sentences;

        public SentenceList(List<Sentence> sentences)
        {
            Sentences = sentences;
        }
    }
}
