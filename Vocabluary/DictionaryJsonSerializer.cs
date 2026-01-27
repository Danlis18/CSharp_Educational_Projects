using System.Text.Encodings.Web;
using System.Text.Json;

namespace Vocabluary
{

    public class DictionaryJsonSerializer
    {
        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public string Serialize(List<VocabularyDictionary> dictionaries)
            => JsonSerializer.Serialize(dictionaries, _options);

        public void SaveToFile(string path, List<VocabularyDictionary> dictionaries)
        {
            var json = Serialize(dictionaries);
            File.WriteAllText(path, json);
        }
    }
}

