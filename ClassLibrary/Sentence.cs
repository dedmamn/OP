using lab2;


namespace ClassLibrary
{
    public class Sentence : TextElement
    {
        public new List<Word> Content { get; set; }

        public Sentence(List<Word> content)
        {
            Content = content;
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
