using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabluary
{    public class DictionariesCollection
    {
        public List<VocabularyDictionary> Items { get; set; } = new();

        public VocabularyDictionary? GetByIndex(int index)
            => (index >= 0 && index < Items.Count) ? Items[index] : null;

        public IEnumerable<VocabularyDictionary> SortByName()
            => Items.OrderBy(d => d.Name);

        public IEnumerable<VocabularyDictionary> SortByType()
            => Items.OrderBy(d => d.Type).ThenBy(d => d.Name);

        public IEnumerable<VocabularyDictionary> SortByWordsCountDesc()
            => Items.OrderByDescending(d => d.Words.Count).ThenBy(d => d.Name);
    }

}
