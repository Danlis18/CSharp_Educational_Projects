using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabluary
{
    public class Dictionary
    {
        public string Name { get; set; }

        public List<Word> words { get; set; } = new List<Word>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dictionary: {Name}");
            foreach (var word in words)
            {
                sb.AppendLine($"Word: {word.Name} | Translations: {string.Join(", ", word.translations)}");
            }
            return sb.ToString();
        }
    }
}
