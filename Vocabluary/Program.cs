using System.Text;
using System.Threading;
using Vocabluary;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

const string dbPath = "dictionaries.json";
const string historyPath = "history.txt";

var serializer = new DictionaryJsonSerializer();
var deserializer = new DictionaryJsonDeserializer();
var history = new SearchHistory(historyPath, maxItems: 10);

var db = new DictionariesCollection();
db.Items = deserializer.LoadFromFile(dbPath);

// Мінімум 2 словники “в обидві сторони”
if (db.Items.Count == 0)
{
    db.Items.Add(new VocabularyDictionary
    {
        Name = "English-Ukrainian Dictionary",
        FromLanguage = "English",
        ToLanguage = "Ukrainian",
        Words = new List<Word>
        {
            new Word { Name = "Hello", Translations = new List<string> { "Привіт", "Вітаю" } },
            new Word { Name = "Goodbye", Translations = new List<string> { "До побачення", "Бувай" } }
        }
    });

    db.Items.Add(new VocabularyDictionary
    {
        Name = "Ukrainian-English Dictionary",
        FromLanguage = "Ukrainian",
        ToLanguage = "English",
        Words = new List<Word>
        {
            new Word { Name = "Дякую", Translations = new List<string> { "Thank you", "Thanks" } },
            new Word { Name = "Будь ласка", Translations = new List<string> { "Please", "You're welcome" } }
        }
    });

    serializer.SaveToFile(dbPath, db.Items);
}

Console.Clear();
Console.WriteLine("Welcome to Vocabulary App!");
Thread.Sleep(900);

while (true)
{
    Console.Clear();

    Console.WriteLine("--- MAIN MENU ---");
    Console.WriteLine("1 - Показати всі словники");
    Console.WriteLine("2 - Створити словник");
    Console.WriteLine("3 - Обрати словник (підменю)");
    Console.WriteLine("4 - Сортування словників");
    Console.WriteLine("5 - Показати останні шукані слова");
    Console.WriteLine("0 - Exit");
    Console.Write("Your choice: ");

    string input = Console.ReadLine();

    int choice;
    if (!int.TryParse(input, out choice))
    {
        ShowMessageAndClear("Некоректний ввід.", 1200);
        continue;
    }

    try
    {
        if (choice == 1)
        {
            Console.Clear();
            ShowDictionaries(db);
            Pause();
        }
        else if (choice == 2)
        {
            Console.Clear();
            CreateDictionary(db);
            serializer.SaveToFile(dbPath, db.Items);
            ShowMessageAndClear("Словник створено і збережено.", 1200);
        }
        else if (choice == 3)
        {
            DictionarySubmenu(db, serializer, dbPath, history);
        }
        else if (choice == 4)
        {
            Console.Clear();
            SortMenu(db);
            Pause();
        }
        else if (choice == 5)
        {
            Console.Clear();
            ShowHistory(history);
            Pause();
        }
        else if (choice == 0)
        {
            return;
        }
        else
        {
            ShowMessageAndClear("Невірний пункт меню.", 1200);
        }
    }
    catch (Exception ex)
    {
        ShowMessageAndClear("Помилка: " + ex.Message, 1500);
    }
}

static void ShowDictionaries(DictionariesCollection db)
{
    if (db.Items.Count == 0)
    {
        Console.WriteLine("Словників немає.");
        return;
    }

    for (int i = 0; i < db.Items.Count; i++)
    {
        var d = db.Items[i];
        Console.WriteLine($"{i + 1}) {d.Name} ({d.Type}), words: {d.Words.Count}");
    }
}

static void CreateDictionary(DictionariesCollection db)
{
    Console.Write("Введи назву словника: ");
    string name = (Console.ReadLine() ?? "").Trim();

    Console.Write("Мова 1 (From): ");
    string from = (Console.ReadLine() ?? "").Trim();

    Console.Write("Мова 2 (To): ");
    string to = (Console.ReadLine() ?? "").Trim();

    if (string.IsNullOrWhiteSpace(name) ||
        string.IsNullOrWhiteSpace(from) ||
        string.IsNullOrWhiteSpace(to))
    {
        Console.WriteLine("Помилка: назва/мови не можуть бути пустими.");
        return;
    }

    db.Items.Add(new VocabularyDictionary
    {
        Name = name,
        FromLanguage = from,
        ToLanguage = to
    });
}

static void DictionarySubmenu(
    DictionariesCollection db,
    DictionaryJsonSerializer serializer,
    string dbPath,
    SearchHistory history)
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("--- ВИБІР СЛОВНИКА ---");
        ShowDictionaries(db);
        Console.Write("Вибери номер словника (0 - назад): ");

        string input = Console.ReadLine();
        int idx;
        if (!int.TryParse(input, out idx))
        {
            ShowMessageAndClear("Некоректний ввід.", 1200);
            continue;
        }

        if (idx == 0) return;

        if (idx < 1 || idx > db.Items.Count)
        {
            ShowMessageAndClear("Некоректний номер словника.", 1200);
            continue;
        }

        var dict = db.GetByIndex(idx - 1);

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"--- DICTIONARY: {dict.Name} ({dict.Type}) ---");
            Console.WriteLine("1 - Додати слово + переклади");
            Console.WriteLine("2 - Переглянути всі слова");
            Console.WriteLine("3 - Пошук перекладу");
            Console.WriteLine("4 - Замінити слово або переклад (перезапис)");
            Console.WriteLine("5 - Видалити слово");
            Console.WriteLine("6 - Видалити конкретний переклад");
            Console.WriteLine("0 - Назад");
            Console.Write("Your choice: ");

            string cInput = Console.ReadLine();
            int c;
            if (!int.TryParse(cInput, out c))
            {
                ShowMessageAndClear("Некоректний ввід.", 1200);
                continue;
            }

            if (c == 0) break;

            if (c == 1)
            {
                Console.Write("Слово: ");
                string word = (Console.ReadLine() ?? "").Trim();

                Console.Write("Переклади (через кому): ");
                string line = (Console.ReadLine() ?? "");

                List<string> translations = new List<string>();
                string[] parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < parts.Length; i++)
                {
                    string t = parts[i].Trim();
                    if (!string.IsNullOrWhiteSpace(t))
                        translations.Add(t);
                }

                dict.AddOrMergeWord(word, translations);
                serializer.SaveToFile(dbPath, db.Items);

                ShowMessageAndClear("Додано/об'єднано успішно.", 1200);
            }
            else if (c == 2)
            {
                Console.Clear();
                Console.WriteLine(dict.ToString());
                Pause();
            }
            else if (c == 3)
            {
                Console.Write("Введи слово для пошуку: ");
                string q = (Console.ReadLine() ?? "").Trim();

                var found = dict.FindWord(q);
                history.Add(q);

                if (found == null)
                {
                    ShowMessageAndClear("Не знайдено.", 1200);
                }
                else
                {
                    Console.WriteLine($"Переклади для '{found.Name}': {string.Join(", ", found.Translations)}");
                    Pause();
                }
            }
            else if (c == 4)
            {
                Console.Write("Яке слово замінити (знайти): ");
                string oldWord = (Console.ReadLine() ?? "").Trim();

                var w = dict.FindWord(oldWord);
                if (w == null)
                {
                    ShowMessageAndClear("Слова немає.", 1200);
                    continue;
                }

                Console.Write("Нове слово (або Enter щоб лишити як є): ");
                string newName = (Console.ReadLine() ?? "").Trim();
                if (!string.IsNullOrWhiteSpace(newName))
                    w.Name = newName;

                Console.Write("Нові переклади (через кому, або Enter щоб лишити як є): ");
                string trLine = (Console.ReadLine() ?? "").Trim();
                if (!string.IsNullOrWhiteSpace(trLine))
                {
                    List<string> newTranslations = new List<string>();
                    string[] p = trLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < p.Length; i++)
                    {
                        string t = p[i].Trim();
                        if (!string.IsNullOrWhiteSpace(t))
                            newTranslations.Add(t);
                    }
                    w.Translations = newTranslations;
                }

                serializer.SaveToFile(dbPath, db.Items);
                ShowMessageAndClear("Оновлено.", 1200);
            }
            else if (c == 5)
            {
                Console.Write("Яке слово видалити: ");
                string del = (Console.ReadLine() ?? "").Trim();

                bool ok = dict.DeleteWord(del);
                if (ok)
                {
                    serializer.SaveToFile(dbPath, db.Items);
                    ShowMessageAndClear("Слово видалено.", 1200);
                }
                else
                {
                    ShowMessageAndClear("Слова немає.", 1200);
                }
            }
            else if (c == 6)
            {
                Console.Write("Слово: ");
                string dw = (Console.ReadLine() ?? "").Trim();

                Console.Write("Який переклад видалити: ");
                string dt = (Console.ReadLine() ?? "").Trim();

                bool ok = dict.DeleteTranslation(dw, dt);
                if (ok)
                {
                    serializer.SaveToFile(dbPath, db.Items);
                    ShowMessageAndClear("Переклад видалено.", 1200);
                }
                else
                {
                    ShowMessageAndClear("Не знайдено слово/переклад.", 1200);
                }
            }
            else
            {
                ShowMessageAndClear("Невірний пункт.", 1200);
            }
        }
    }
}

static void SortMenu(DictionariesCollection db)
{
    Console.WriteLine("--- SORT MENU ---");
    Console.WriteLine("1 - За назвою");
    Console.WriteLine("2 - За типом (From-To)");
    Console.WriteLine("3 - За кількістю слів (спадання)");
    Console.Write("Your choice: ");

    string input = Console.ReadLine();
    int c;
    if (!int.TryParse(input, out c))
    {
        Console.WriteLine("Некоректний ввід.");
        return;
    }

    IEnumerable<VocabularyDictionary> sorted;

    if (c == 1)
        sorted = db.SortByName();
    else if (c == 2)
        sorted = db.SortByType();
    else if (c == 3)
        sorted = db.SortByWordsCountDesc();
    else
        sorted = new List<VocabularyDictionary>();

    foreach (var d in sorted)
        Console.WriteLine($"{d.Name} ({d.Type}), words: {d.Words.Count}");
}

static void ShowHistory(SearchHistory history)
{
    var items = history.Read().ToList();

    if (items.Count == 0)
    {
        Console.WriteLine("Історія пуста.");
        return;
    }

    Console.WriteLine("Останні шукані слова:");
    for (int i = 0; i < items.Count; i++)
    {
        Console.WriteLine("- " + items[i]);
    }
}

static void ShowMessageAndClear(string message, int milliseconds)
{
    Console.WriteLine();
    Console.WriteLine(message);
    Thread.Sleep(milliseconds);
    Console.Clear();
}

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("Натисни будь-яку клавішу щоб продовжити...");
    Console.ReadKey(true);
}
