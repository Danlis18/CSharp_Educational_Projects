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

        public string TypeOfVocabularyDictionary
        {
            get
            {
                string result = FromLanguage + "-" + ToLanguage;
                return result;
            }
        }

        public override string ToString()
        {
            return $"Dictionary: {Name} | Vocabulary type: {TypeOfVocabularyDictionary} | Words count: {Words.Count}";
        }

        public Word? FindWord(string word)
            => Words.FirstOrDefault(w => w.Name.Equals(word, StringComparison.OrdinalIgnoreCase));

        public void AddWord(string word, IEnumerable<string> translations)
        {
            var w = FindWord(word);
            if (w == null)
            {
                Words.Add(new Word
                {
                    Name = word,
                    Translations = translations
                        .Where(t => !string.IsNullOrWhiteSpace(t))
                        .Distinct(StringComparer.OrdinalIgnoreCase) //повтори не додає
                        .ToList()
                });
                return;
            }

            var ifExist = w.Translations
                .Concat(translations)
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            w.Translations = ifExist;
        }

        public bool DeleteWord(string word)
        {
            var w = FindWord(word);

            if (w == null)
            {
                return false;
            }

            return Words.Remove(w);
        }

        public bool DeleteTranslation(string word, string translation)
        {
            var w = FindWord(word);
            if (w == null)
            {
                return false;
            }

            var removed = w.Translations.RemoveAll(t =>
                t.Equals(translation, StringComparison.OrdinalIgnoreCase)) > 0;

            if (w.Translations.Count == 0)
            {
                Words.Remove(w);
            }

            return removed;
        }
    }
}
