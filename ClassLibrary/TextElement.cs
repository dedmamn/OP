
namespace ClassLibrary
{
    public abstract class TextElement
    {
        public string? Content { get; set; }

        protected TextElement() { }

        protected TextElement(string content)
        {
            Content = content;
        }

        public abstract TextElement? CreateFromFile(string path);

        public abstract void WriteToFile(string path);

        public virtual void Delete()
        {
            Content = null;
        }

        public virtual void Delete(string path) { }
    }
}
