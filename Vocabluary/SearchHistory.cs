namespace Vocabluary
{
    public class SearchHistory
    {
        private string path;
        private int maxCount;

        public SearchHistory(string path, int maxCount = 10)
        {
            path = path;
            maxCount = Math.Max(1, maxCount);
        }

        public void Add(string query)
        {
            if (query == null)
            {
                return;
            }

            query = query.Trim();

            if (query == "")
            {
                return;
            }

            var items = Read().ToList();

            items.RemoveAll(x => x.Equals(query, StringComparison.OrdinalIgnoreCase));
            items.Insert(0, query);

            if (items.Count > maxCount)
            {
                items = items.Take(maxCount).ToList();
            }

            File.WriteAllLines(path, items);
        }

        public IEnumerable<string> Read()
        {
            if (!File.Exists(path))
            {
                return Enumerable.Empty<string>();
            }

            return File.ReadAllLines(path)
                .Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x));
        }
    }
}
