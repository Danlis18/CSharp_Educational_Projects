using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabluary
{
    public class VocabularyDictionary
    {
        public string Name { get; set; } 
        public string FromLanguage { get; set; }
        public string ToLanguage { get; set; }

        public List<Word> Words { get; set; } = new List<Word>();

        public string Type => $"{FromLanguage}-{ToLanguage}";

        public override string ToString()
        {
            return $"Dictionary: {Name} | Type: {Type} | Words count: {Words.Count}";
        }

        public Word? FindWord(string word)
            => Words.FirstOrDefault(w => w.Name.Equals(word, StringComparison.OrdinalIgnoreCase));

        public void AddOrMergeWord(string word, IEnumerable<string> translations)
        {
            var w = FindWord(word);
            if (w == null)
            {
                Words.Add(new Word
                {
                    Name = word,
                    Translations = translations
                        .Where(t => !string.IsNullOrWhiteSpace(t))
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList()
                });
                return;
            }

            var merged = w.Translations
                .Concat(translations)
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            w.Translations = merged;
        }

        public bool DeleteWord(string word)
        {
            var w = FindWord(word);
            if (w == null) return false;
            return Words.Remove(w);
        }

        public bool DeleteTranslation(string word, string translation)
        {
            var w = FindWord(word);
            if (w == null) return false;

            var removed = w.Translations.RemoveAll(t =>
                t.Equals(translation, StringComparison.OrdinalIgnoreCase)) > 0;

            // якщо перекладів не лишилось — видаляємо слово повністю
            if (w.Translations.Count == 0)
                Words.Remove(w);

            return removed;
        }
    }
}
