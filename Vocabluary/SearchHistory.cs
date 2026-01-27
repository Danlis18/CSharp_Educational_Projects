namespace Vocabluary
{
    public class SearchHistory
    {
        private readonly string _path;
        private readonly int _maxItems;

        public SearchHistory(string path, int maxItems = 10)
        {
            _path = path;
            _maxItems = Math.Max(1, maxItems);
        }

        public void Add(string query)
        {
            query = (query ?? "").Trim();
            if (string.IsNullOrWhiteSpace(query)) return;

            var items = Read().ToList();

            // прибираємо дубль і кладемо на початок
            items.RemoveAll(x => x.Equals(query, StringComparison.OrdinalIgnoreCase));
            items.Insert(0, query);

            if (items.Count > _maxItems)
                items = items.Take(_maxItems).ToList();

            File.WriteAllLines(_path, items);
        }

        public IEnumerable<string> Read()
        {
            if (!File.Exists(_path)) return Enumerable.Empty<string>();
            return File.ReadAllLines(_path)
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x));
        }
    }
}
