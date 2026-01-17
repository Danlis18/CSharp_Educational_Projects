using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using ClassLib_PC;

//створити колекцію (на базі узагальненого класу List<T>) і додати в колекцію 4-5 об'єктів класу «РС».
List<PC> pcCollection = new List<PC>
{
    new PC { Brand = "Dell", SerialNumber = "12345", Processor = "Intel Core i7", RamSize = 16, StorageSize = 512 },
    new PC { Brand = "HP", SerialNumber = "67890", Processor = "AMD Ryzen 5", RamSize = 8, StorageSize = 256 },
    new PC { Brand = "Lenovo", SerialNumber = "54321", Processor = "Intel Core i5", RamSize = 12, StorageSize = 1024 },
    new PC { Brand = "Asus", SerialNumber = "09876", Processor = "AMD Ryzen 7", RamSize = 16, StorageSize = 2048 }
};

//Виконати серіалізацію колекції в json-файл з ім'ям «listSerial. json ». У разі наявності аналогічного файлу в каталозі старий файл перезаписати новим файлом і вивести про це повідомлення.
var options = new JsonSerializerOptions
{
    WriteIndented = true 
};

string jsonString = JsonSerializer.Serialize(pcCollection, options);

Console.WriteLine(jsonString);

string path = "listSerial.json";

if (File.Exists(path))
{
    Console.WriteLine("Файл вже існує і буде перезаписаний");
}
else
{
    Console.WriteLine("Файл створено");
}

File.WriteAllText(path, jsonString);


