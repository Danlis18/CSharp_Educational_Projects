namespace _009_010_HomeWork
{
    class HomeLibrary
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> Search(SearchField field, string value)
        {
            List<Book> result = new List<Book>();

            foreach (var b in books)
            {
                if (field == SearchField.Year && b.Year.ToString() == value)
                    result.Add(b);

                if (field == SearchField.Author &&
                    b.Author.Equals(value, StringComparison.OrdinalIgnoreCase))
                    result.Add(b);

                if (field == SearchField.Genre &&
                    b.Genre.Equals(value, StringComparison.OrdinalIgnoreCase))
                    result.Add(b);
            }

            return result;
        }

        public void PrintBooks()
        {
            foreach (var b in books)
            {
                Console.WriteLine(b.ToString());
            }
        }
    }
}
