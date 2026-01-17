using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using ClassLib_PC;


//виконати десеріалізацію колекції, створеної в проекті з ім'ям «SerializConsolApp», і вивести її на екран.
string path = "listSerial.json";
string jsonContent = File.ReadAllText(path);
Console.WriteLine(jsonContent);
List<PC> pcCollection = JsonSerializer.Deserialize<List<PC>>(jsonContent);
foreach (var pc in pcCollection)
{
    Console.WriteLine($"Brand: {pc.Brand}, Serial Number: {pc.SerialNumber}, Processor: {pc.Processor}, RAM Size: {pc.RamSize}GB, Storage Size: {pc.StorageSize}GB");
}
