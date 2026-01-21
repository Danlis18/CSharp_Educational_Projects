namespace Vocabluary
{
    public class Word
    {
        public string Name { get; set; }

        public List<string> translations { get; set; } = new List<string>();
    }
}
