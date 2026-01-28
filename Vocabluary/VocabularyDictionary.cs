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

        public Word FindWord(string word)
        {
            if (word == null)
            {
                return null;
            }

            word = word.Trim();
            if (word.Length == 0)
            {
                return null;
            }

            for (int i = 0; i < Words.Count; i++)
            {
                if (Words[i].Name == null)
                {
                    continue;
                }

                string name = Words[i].Name.Trim();

                if (name.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return Words[i];
                }
            }

            return null;
        }


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

        public void PrintAllWords()
        {
            if (Words == null || Words.Count == 0)
            {
                Console.WriteLine("У цьому словнику ще немає слів.");
                return;
            }

            for (int i = 0; i < Words.Count; i++)
            {
                Word w = Words[i];

                Console.Write((i + 1) + ") " + w.Name + " - ");

                if (w.Translations == null || w.Translations.Count == 0)
                {
                    Console.WriteLine("(немає перекладів)");
                }
                else
                {
                    for (int j = 0; j < w.Translations.Count; j++)
                    {
                        Console.Write(w.Translations[j]);

                        if (j != w.Translations.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

    }
}
