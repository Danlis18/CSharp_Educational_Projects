using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Vocabluary;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Welcome to Vocabluary App!");

Dictionary myDictionary = new Dictionary()
{
    Name = "English-Ukrainian Dictionary",
    words = new List<Word>()
    {
        new Word()
        {
            Name = "Hello",
            translations = new List<string>() { "Привіт", "Вітаю" }
        },
        new Word()
        {
            Name = "Goodbye",
            translations = new List<string>() { "До побачення", "Бувай" }
        }
    }
};

//Serialization
/*var options = new JsonSerializerOptions
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
};

string jsonString = JsonSerializer.Serialize(myDictionary);

Console.WriteLine(jsonString);

string path = "listWordsSerial.json";
File.WriteAllText(path, jsonString);*/


//Deserialization
/*string jsonContent = File.ReadAllText(path);
Console.WriteLine(jsonContent);

string dictionarуJson = File.ReadAllText("listWordsSerial.json");*/


string pathHistory = "history.txt";
string LastSearches;

List<string> recentSearches = new List<string>();

/*//Записування
using StreamWriter writer = new StreamWriter(pathHistory);
writer.WriteLine($"...: {pathHistory.Length}"); ; //будь-що записуємо 

//Зчитування
using StreamReader reader = new StreamReader(pathHistory);
string text = reader.ReadToEnd(); //зчитається весь текст
//string text = reader.ReadLine(); //зчитує один рядок
Console.WriteLine(text);

//Зчитування до поки не буде пустий
string line = null;
while ((line = reader.ReadLine()) != null)
{
    Console.WriteLine(line);
}*/


while (true)
{
    Console.WriteLine("\n--- LIST MENU ---");
    Console.WriteLine("1 - Створювати словник");
    Console.WriteLine("2 - Додавати слово і його переклад в уже існуючий словник");
    Console.WriteLine("3 - Переглядати всі слова і переклади словника");
    Console.WriteLine("4 - Шукати переклад слова");
    Console.WriteLine("5 - Замінювати слово або його переклад в словнику");
    Console.WriteLine("6 - Видаляти слово або переклад");
    Console.WriteLine("7 - Сортувати словники по заданим критеріям");
    Console.WriteLine("8 - Показувати останні шукані слова");
    Console.WriteLine("0 - Exit");
    Console.Write("Your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    try
    {
        switch (choice)
        {
            case 1:
                //Створювати словник
                Dictionary dict = new Dictionary();
                Console.WriteLine("Enter dictionary Name:");
                dict.Name = Console.ReadLine();
                Console.WriteLine("Dictionary created.");
                break;

            case 2:
                //Додавати слово і його переклад в уже існуючий словник
                Word word = new Word();
                Console.Write("Enter the word: ");
                word.Name = Console.ReadLine();
                Console.Write("Enter translations (comma separated): ");
                word.translations = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
                myDictionary.words.Add(word);

                break;
            case 3:
                //Переглядати всі слова і переклади словника
                Console.WriteLine(myDictionary.ToString());

                break;
            case 4:
                //Шукати переклад слова
                Console.Write("Enter the word to search: ");
                string searchWord = Console.ReadLine();

                var foundWord = myDictionary.words.FirstOrDefault(w => w.Name.Equals(searchWord, StringComparison.OrdinalIgnoreCase));
                
                if (foundWord != null)
                {
                    Console.WriteLine($"Translations for '{foundWord.Name}': {string.Join(", ", foundWord.translations)}");
                }
                else
                {
                    Console.WriteLine("Word not found in the dictionary.");
                }
                LastSearches = searchWord;
                break;

            case 5:
                //Замінювати слово або його переклад в словнику
                Console.Write("Enter the word to replace: ");
                string searchToReplace = Console.ReadLine();

                var foundToReplace = myDictionary.words.FirstOrDefault(w => w.Name.Equals(searchToReplace, StringComparison.OrdinalIgnoreCase));
                if (foundToReplace != null)
                {
                    Console.Write("Enter new word: ");
                    string newWord = Console.ReadLine();
                    foundToReplace.Name = newWord;
                    Console.Write("Enter new translations (comma separated): ");
                    foundToReplace.translations = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
                    myDictionary.words.Add(foundToReplace);
                }
                break;

            case 6:
                Console.Write("Enter the word to dell: ");
                string WordToDell = Console.ReadLine();

                var foundToDell = myDictionary.words.FirstOrDefault(w => w.Name.Equals(WordToDell, StringComparison.OrdinalIgnoreCase));
                if (foundToDell != null)
                {
                    myDictionary.words.Remove(foundToDell);
                }

                break;

            case 7:
                
                break;

            case 8:
                //Показувати останні шукані слова
                //Зчитування






                break;
            case 0:
                return;

            default:
                Console.WriteLine("Invalid menu item.");
                break;
        }
    }
    catch (Exception exception)
    {
        Console.WriteLine("Error: " + exception.Message);
    }
}