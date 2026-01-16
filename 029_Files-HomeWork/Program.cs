using _029_Files_HomeWork;
using System.Text; 
using System.Xml.Serialization;

//ЗАВДАННЯ 6:
string path = "example.txt";

//Записування
/*using FileStream fileStreamW = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

string textW = "Hello World!";
byte[] bytes = Encoding.UTF8.GetBytes(textW);

fileStreamW.Write(bytes, 0, bytes.Length);*/

//Зчитування
/*using FileStream fileStreamR = new FileStream(path, FileMode.Open, FileAccess.Read);

byte[] buffer = new byte[fileStreamR.Length];
fileStreamR.Read(buffer, 0, buffer.Length);

string textR = Encoding.UTF8.GetString(buffer);
Console.WriteLine(textR);
*/


//ЗАВДАННЯ 7:
/*string path3 = "points.xml";

var shop = new Shop("Shop", new List<Product>
{
    new Product("Bread", 25.50m, "Fresh bread"),
    new Product("Milk", 42.00m, "2.5% fat"),
    new Product("Chocolate", 60.99m, "Dark 70%")
});


//Серіалізація
using (FileStream fs = new FileStream(path3, FileMode.Create))
{
    XmlSerializer serializer = new XmlSerializer(typeof(Shop));
    serializer.Serialize(fs, shop);
}

//Десеріалізація
using (FileStream fs = new FileStream(path3, FileMode.Open))
{
    XmlSerializer serializer = new XmlSerializer(typeof(Shop));
    Shop deserializedShop = (Shop)serializer.Deserialize(fs);

    foreach (var p in deserializedShop.ListOfProducts)
        Console.WriteLine(p);
}*/

