using JasonFiles;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

//Серіалізація
/*Point point = new Point { X = 10, Y = 20 };

var options = new JsonSerializerOptions
{
    WriteIndented = true // Додає пробіли та переноси рядків
};

string jsonString = JsonSerializer.Serialize(point, options);

Console.WriteLine(jsonString);

string path = "point.json";
File.WriteAllText(path, jsonString);*/


//Десеріалізація
/*string path = "point.json";
string jsonContent = File.ReadAllText(path);
Console.WriteLine(jsonContent);
Point point = JsonSerializer.Deserialize<Point>(jsonContent);
Console.WriteLine(point);*/