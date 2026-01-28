using System.Text.Encodings.Web;
using System.Text.Json;

namespace Vocabluary
{

    public class DictionaryJsonSerializer
    {
        private readonly JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        }; //для перевірки що записується в Json

        public string Serialize(List<VocabularyDictionary> dictionaries)
            => JsonSerializer.Serialize(dictionaries, options);

        public void SaveToFile(string path, List<VocabularyDictionary> dictionaries)
        {
            var json = Serialize(dictionaries);
            File.WriteAllText(path, json);
        }
    }
}

