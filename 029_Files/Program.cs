using _029_Files;

using System.Xml.Serialization;
//Класи роботи з файлами:

// FileStream (вважається низькорівневим)
/*string path = "example.txt";*/

//Записування
/*using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write); //using для звільнення некерованих ресурсів

string text = "Hello World!";
byte[] bytes = Encoding.UTF8.GetBytes(text); //конвертує текст масив в байти
    
fileStream.Write(bytes, 0, bytes.Length); // (масив байтів | з якого байта починати запис | кільість байтів)*/

//Зчитування
/*using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

byte[] buffer = new byte[fileStream.Length];
fileStream.Read(buffer, 0, buffer.Length);

string text = Encoding.UTF8.GetString(buffer);
Console.WriteLine(text);*/



// StreamReader, StreamWriter
/*string path = "data.txt";*/

//Записування
/*using StreamWriter writer = new StreamWriter(path);
writer.WriteLine($"Hello DANYLO, year: {path.Length}"); ; //будь-що записуємо */

//Зчитування
/*using StreamReader reader = new StreamReader(path);
string text = reader.ReadToEnd(); //зчитається весь текст
string text = reader.ReadLine(); //зчитує один рядок
Console.WriteLine(text);

//Зчитування до поки не буде пустий
string line = null;
while((line = reader.ReadLine()) != null){
    Console.WriteLine(line);
}
*/

//З класу запитусуємо у файл:
/*Point point = new Point() {X = 4, Y = 5 };
using StreamWriter writer = new StreamWriter(path);

writer.WriteLine(point);*/

//З класу зчитуємо у консоль:
/* using StreamReader streamReader = new StreamReader(path);
string RideLine = streamReader.ReadLine();


string[] parts = line.Split(",");

Point point = new Point();
point.X = Convert.ToInt32(parts[0]);
point.Y = Convert.ToInt32(parts[1]);
Console.WriteLine(point);*/

//Завдання - запис в список деклька точок
/*using StreamReader streamReader = new StreamReader(path);
List<Point> points = new List<Point>();

string RideLine = null;
while ((RideLine = streamReader.ReadLine()) != null)
{
    Point p = new Point();
    string[] parts = RideLine.Split(",");
    p.X = Convert.ToInt32(parts[0]);
    p.Y = Convert.ToInt32(parts[1]);

    points.Add(p);
}

foreach (Point p in points)
{
    Console.WriteLine(p);
}*/



// BinaryReader, BinaryWriter
//Записування
/*string path = "data.bin";
using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
BinaryWriter binaryWriter = new BinaryWriter(fileStream);
binaryWriter.Write(312.21);
binaryWriter.Write("Helik Worldik");
binaryWriter.Write(true);
*/

//Зчитування
/*string path = "data.bin";
using FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
using BinaryReader binaryReader = new BinaryReader(fileStream);

double d = binaryReader.ReadDouble();
string s = binaryReader.ReadString();
bool b = binaryReader.ReadBoolean();

Console.WriteLine(d);
Console.WriteLine(s);
Console.WriteLine(b);
*/



// Серіалізація об'єктів(XML, JSON)
//Серілізація - це збереження стану об'єкта з метою його подальшого відновлення.
/*List<Point> point = new List<Point>() { 
    new Point(){X = 0,Y = 0 },
    new Point(){X = -54,Y = 45 },
    new Point(){X = 423,Y = 77 },
};

XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>));

string path = "points.xml";
FileStream fileStream = new FileStream(path, FileMode.Create);
xmlSerializer.Serialize(fileStream, point);
*/

//Десеріалізація - це відновлення (зчитування)
/*string path = "points.xml";
FileStream fileStream = new FileStream(path, FileMode.Open);
XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>));

List<Point> points = (List<Point>)xmlSerializer.Deserialize(fileStream);

foreach (Point p in points)
{
    Console.WriteLine(p);
}
*/

