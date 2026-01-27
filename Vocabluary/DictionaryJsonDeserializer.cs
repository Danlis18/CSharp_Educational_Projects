using System.Text.Json;

namespace Vocabluary
{

    public class DictionaryJsonDeserializer
    {
        public List<VocabularyDictionary> LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new List<VocabularyDictionary>();

            var json = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<List<VocabularyDictionary>>(json);

            return data ?? new List<VocabularyDictionary>();
        }
    }
}

