using System.Text;
using System.Threading;
using Vocabluary;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

const string collectionPath = "dictionaries.json";
const string historyPath = "history.txt";

DictionaryJsonSerializer serializer = new DictionaryJsonSerializer();
DictionaryJsonDeserializer deserializer = new DictionaryJsonDeserializer();
SearchHistory history = new SearchHistory(historyPath, maxCount: 10);

Collection collection = new Collection();
collection.GroupOfWords = deserializer.TakeFromFile(collectionPath).ToList();

if (collection.GroupOfWords.Count == 0)
{
    collection.GroupOfWords.Add(new VocabularyDictionary
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

    collection.GroupOfWords.Add(new VocabularyDictionary
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

    serializer.SaveToFile(collectionPath, collection.GroupOfWords);
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

        input = Console.ReadLine();
        if (!int.TryParse(input, out choice))
        {
            ShowMessageAndClear("Некоректний ввід.", 1200);
            continue;
        }

        try
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    ShowDictionaries(collection);
                    Pause();
                    break;

                case 2:
                    Console.Clear();
                    CreateDictionary(collection);
                    serializer.SaveToFile(collectionPath, collection.GroupOfWords);
                    ShowMessageAndClear("Словник створено і збережено.", 1200);
                    break;

                case 3:
                    DictionaryAnotherMenu(collection, serializer, collectionPath, history);
                    break;

                case 4:
                    Console.Clear();
                    SortMenu(collection);
                    Pause();
                    break;

                case 5:
                    Console.Clear();
                    ShowHistory(history);
                    Pause();
                    break;

                case 0:
                    return;

                default:
                    ShowMessageAndClear("Невірний пункт меню.", 1200);
                    break;
            }
        }
        catch (Exception ex)
        {
            ShowMessageAndClear("Помилка: " + ex.Message, 1500);
        }
    }

    static void ShowDictionaries(Collection collection)
    {
        if (collection.GroupOfWords.Count == 0)
        {
            Console.WriteLine("Словників немає.");
            return;
        }

        for (int i = 0; i < collection.GroupOfWords.Count; i++)
        {
            VocabularyDictionary d = collection.GroupOfWords[i];
            Console.WriteLine((i + 1) + ") " + d.Name + " (" + d.TypeOfVocabularyDictionary + "), words: " + d.Words.Count);
        }
    }

    static void CreateDictionary(Collection collection)
    {
        Console.Write("Введи назву словника: ");
        string name = Console.ReadLine();
        if (name == null)
        {
            name = "";
        }
        name = name.Trim();

        Console.Write("Мова 1 (From): ");
        string from = Console.ReadLine();
        if (from == null)
        {
            from = "";
        }
        from = from.Trim();

        Console.Write("Мова 2 (To): ");
        string to = Console.ReadLine();
        if (to == null)
        {
            to = "";
        }
        to = to.Trim();

        if (name.Length == 0 || from.Length == 0 || to.Length == 0)
        {
            Console.WriteLine("Помилка: назва/мови не можуть бути пустими.");
            return;
        }

        VocabularyDictionary dict = new VocabularyDictionary();
        dict.Name = name;
        dict.FromLanguage = from;
        dict.ToLanguage = to;
        dict.Words = new List<Word>();

        collection.GroupOfWords.Add(dict);
    }

    static void DictionaryAnotherMenu(Collection collection, DictionaryJsonSerializer serializer, string collectionPath, SearchHistory history)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("--- ВИБІР СЛОВНИКА ---");
            ShowDictionaries(collection);
            Console.Write("Вибери номер словника (0 - назад): ");

            string input = Console.ReadLine();

            int idx;
            if (!int.TryParse(input, out idx))
            {
                ShowMessageAndClear("Некоректний ввід.", 1200);
                continue;
            }

            if (idx == 0)
            {
                return;
            }

            if (idx < 1 || idx > collection.GroupOfWords.Count)
            {
                ShowMessageAndClear("Некоректний номер словника.", 1200);
                continue;
            }

            VocabularyDictionary dict = collection.GroupOfWords[idx - 1];

            while (true)
            {
                Console.Clear();

                Console.WriteLine("--- DICTIONARY: " + dict.Name + " (" + dict.TypeOfVocabularyDictionary + ") ---");
                Console.WriteLine("1 - Додати слово + переклади");
                Console.WriteLine("2 - Переглянути всі слова");
                Console.WriteLine("3 - Пошук перекладу");
                Console.WriteLine("4 - Замінити слово або переклад");
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

                if (c == 0)
                {
                    break;
                }

                switch (c)
                {
                    case 1:
                        AddWordToDictionary(dict, serializer, collectionPath, collection);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine(dict.ToString());
                        Pause();
                        break;

                    case 3:
                        SearchWord(dict, history);
                        break;

                    case 4:
                        ReplaceWordOrTranslations(dict, serializer, collectionPath, collection);
                        break;

                    case 5:
                        DeleteWord(dict, serializer, collectionPath, collection);
                        break;

                    case 6:
                        DeleteTranslation(dict, serializer, collectionPath, collection);
                        break;

                    default:
                        ShowMessageAndClear("Невірний пункт.", 1200);
                        break;
                }
            }
        }
    }

    static void AddWordToDictionary(VocabularyDictionary dict, DictionaryJsonSerializer serializer, string collectionPath, Collection collection)
    {
        Console.Write("Слово: ");
        string word = Console.ReadLine();
        if (word == null)
        { 
            word = "";
        }
        word = word.Trim();

        Console.Write("Переклади (через кому): ");
        string line = Console.ReadLine();
        if (line == null)
        {
            line = "";
        }

        List<string> translations = new List<string>();
        string[] parts = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < parts.Length; i++)
        {
            string t = parts[i].Trim();
            if (t.Length > 0)
            {
                translations.Add(t);
            }
        }

        dict.AddWord(word, translations);

        serializer.SaveToFile(collectionPath, collection.GroupOfWords);
        ShowMessageAndClear("Додано/об'єднано успішно.", 1200);
    }

    static void SearchWord(VocabularyDictionary dict, SearchHistory history)
    {
        Console.Write("Введи слово для пошуку: ");
        string q = Console.ReadLine();
        if (q == null)
        {
            q = "";
        }
        q = q.Trim();

        Word found = dict.FindWord(q);
        history.Add(q);

        if (found == null)
        {
            ShowMessageAndClear("Не знайдено.", 1200);
        }
        else
        {
            Console.WriteLine("Переклади для '" + found.Name + "': " + string.Join(", ", found.Translations));
            Pause();
        }
    }

    static void ReplaceWordOrTranslations(VocabularyDictionary dict, DictionaryJsonSerializer serializer, string collectionPath, Collection collection)
    {
        Console.Write("Яке слово замінити (знайти): ");
        string oldWord = Console.ReadLine();
        if (oldWord == null)
        {
            oldWord = "";
        }
        oldWord = oldWord.Trim();

        Word w = dict.FindWord(oldWord);
        if (w == null)
        {
            ShowMessageAndClear("Слова немає.", 1200);
            return;
        }

        Console.Write("Нове слово (або Enter щоб лишити як є): ");
        string newName = Console.ReadLine();
        if (newName == null)
        {
            newName = "";
        }
        newName = newName.Trim();

        if (newName.Length > 0)
        {
            w.Name = newName;
        }

        Console.Write("Нові переклади (через кому, або Enter щоб лишити як є): ");
        string trLine = Console.ReadLine();
        if (trLine == null)
        {
            trLine = "";
        }
        trLine = trLine.Trim();

        if (trLine.Length > 0)
        {
            List<string> newTranslations = new List<string>();
            string[] p = trLine.Split(',', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < p.Length; i++)
            {
                string t = p[i].Trim();
                if (t.Length > 0)
                {
                    newTranslations.Add(t);
                }
            }

            w.Translations = newTranslations;
        }

        serializer.SaveToFile(collectionPath, collection.GroupOfWords);
        ShowMessageAndClear("Оновлено.", 1200);
    }

    static void DeleteWord(VocabularyDictionary dict, DictionaryJsonSerializer serializer, string collectionPath, Collection collection)
    {
        Console.Write("Яке слово видалити: ");
        string del = Console.ReadLine();
        if (del == null)
        {
            del = "";
        }
        del = del.Trim();

        bool ok = dict.DeleteWord(del);
        if (ok)
        {
            serializer.SaveToFile(collectionPath, collection.GroupOfWords);
            ShowMessageAndClear("Слово видалено.", 1200);
        }
        else
        {
            ShowMessageAndClear("Слова немає.", 1200);
        }
    }

    static void DeleteTranslation(VocabularyDictionary dict, DictionaryJsonSerializer serializer, string collectionPath, Collection collection)
    {
        Console.Write("Слово: ");
        string dw = Console.ReadLine();
        if (dw == null)
        {
            dw = "";
        }
        dw = dw.Trim();

        Console.Write("Який переклад видалити: ");
        string dt = Console.ReadLine();
        if (dt == null)
        {
            dt = "";
        }
        dt = dt.Trim();

        bool ok = dict.DeleteTranslation(dw, dt);
        if (ok)
        {
            serializer.SaveToFile(collectionPath, collection.GroupOfWords);
            ShowMessageAndClear("Переклад видалено.", 1200);
        }
        else
        {
            ShowMessageAndClear("Не знайдено слово/переклад.", 1200);
        }
    }

    static void SortMenu(Collection collection)
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
        {
            sorted = collection.SortByName();
        }
        else if (c == 2)
        {
            sorted = collection.SortByType();
        }
        else if (c == 3)
        {
            sorted = collection.SortByWordsCountDesc();
        }
        else
        {
            sorted = new List<VocabularyDictionary>();
        }

        foreach (VocabularyDictionary d in sorted)
        {
            Console.WriteLine(d.Name + " (" + d.TypeOfVocabularyDictionary + "), words: " + d.Words.Count);
        }
    }

    static void ShowHistory(SearchHistory history)
    {
        List<string> items = history.Read().ToList();

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
}






