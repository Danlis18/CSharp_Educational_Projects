using _009_010_HomeWork;

HomeLibrary library = new HomeLibrary();

Console.WriteLine("=== DEMO: HOME LIBRARY ===\n");

// 1. Додаємо книги
library.AddBook(new Book("Dune", "Frank Herbert", "Sci-Fi", 1965));
library.AddBook(new Book("It", "Stephen King", "Horror", 1986));
library.AddBook(new Book("The Hobbit", "Tolkien", "Fantasy", 1937));
library.AddBook(new Book("Carrie", "Stephen King", "Horror", 1974));

// 2. Виводимо всі книги
Console.WriteLine("All books in library:");
library.PrintBooks();
Console.WriteLine();

// 3. Пошук за автором
Console.WriteLine("Search by author 'Stephen King':");
var byAuthor = library.Search(SearchField.Author, "Stephen King");
foreach (var b in byAuthor)
    Console.WriteLine(b);
Console.WriteLine();

// 4. Пошук за жанром
Console.WriteLine("Search by genre 'Horror':");
var byGenre = library.Search(SearchField.Genre, "Horror");
foreach (var b in byGenre)
    Console.WriteLine(b);
Console.WriteLine();

// 5. Пошук за роком
Console.WriteLine("Search by year '1965':");
var byYear = library.Search(SearchField.Year, "1965");
foreach (var b in byYear)
    Console.WriteLine(b);
Console.WriteLine();

// 6. Видалення книги
Console.WriteLine("Removing book 'It'...");
Book removeBook = byAuthor[0]; // беремо першу книгу King
library.RemoveBook(removeBook);
Console.WriteLine("Book removed.\n");

// 7. Виводимо після видалення
Console.WriteLine("Library after removing 'It':");
library.PrintBooks();

Console.WriteLine("\n=== END OF DEMO ===");