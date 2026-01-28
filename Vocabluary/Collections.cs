using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabluary
{
    public class Collection
    {
        public List<VocabularyDictionary> GroupOfWords { get; set; }

        public Collection()
        {
            GroupOfWords = new List<VocabularyDictionary>();
        }

        public VocabularyDictionary GetByIndex(int index)
        {
            VocabularyDictionary dictionary = GroupOfWords[index];
            return dictionary;
        }

        public IEnumerable<VocabularyDictionary> SortByName()
        {
            IEnumerable<VocabularyDictionary> result;

            result = GroupOfWords.OrderBy(d =>
            {
                return d.Name;
            });

            return result;
        }

        public IEnumerable<VocabularyDictionary> SortByType()
        {
            IEnumerable<VocabularyDictionary> result;
            result = GroupOfWords.OrderBy(d =>
            {
                return d.TypeOfVocabularyDictionary;
            })
            .ThenBy(d =>
            {
                return d.Name;
            });
            return result;
        }

        public IEnumerable<VocabularyDictionary> SortByWordsCountDesc()
        {
            IEnumerable<VocabularyDictionary> result;
            result = GroupOfWords.OrderByDescending(d =>
            {
                return d.Words.Count;
            });
            return result;
        }
    }
}
