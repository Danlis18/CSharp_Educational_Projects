namespace Vocabluary
{
    public class Word
    {
        public string Name { get; set; }
        public List<string> Translations { get; set; } = new List<string>();
        public override string ToString()
        {
            return $"Word: {Name} | Translations: {string.Join(", ", Translations)}";
        }  
    }
}
