using System.Text.Json;

namespace Vocabluary
{
    public class DictionaryJsonDeserializer
    {
        public List<VocabularyDictionary> TakeFromFile(string path)
        {
            if (!File.Exists(path))
            {
                return new List<VocabularyDictionary>();
            }

            var json = File.ReadAllText(path);
            var list = JsonSerializer.Deserialize<List<VocabularyDictionary>>(json);

            if (list == null)
            {
                list = new List<VocabularyDictionary>();
            }

            return list;
        }
    }
}

