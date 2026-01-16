using _034_LINQ;

string[] countries = { "Albania", "UK", "Ukraine",
                                "Lithuania", "Andorra", "Austria",
                                "Latvia", "Liechtenstein", "Switzerland",
                                "Ireland", "Sweden","Italy", "France",
                                "Liechtenstein", "Spain", "Turkey", "Germany",
                                "Switzerland", "Monaco", "Montenegro",
                                "Norway", "Finland", "Turkey", "UK", "Poland",
                                "Portugal", "Lithuania", "Luxembourg"
                                };



// джерело даних
List<Product> products = new List<Product>();


//генеруємо список із 100 випадкових об'єктів
for (int i = 1; i < 100; i++)
{
    // Sleep() потрібен, щоб компілятор на кожній
    // ітерації створював новий об'єкт Random,
    // інакше, компілятор використовує
    // оптимізацію і не змінює об'єкт Random для
    // всіх ітерацій
    Thread.Sleep(20);
    products.Add(new Product
    {
        Name = "Product" + (i),
        Price = (new Random()).Next(0, 1000),
        Manufacturer =
    countries[(new Random()).
    Next(0, countries.Length - 1)],
        Count = (new Random()).Next(0, 10)
    });
}


Console.WriteLine("All products:");
foreach (var item in products)
{
    Console.WriteLine(item);
}



/*IEnumerable<Product> query = from p in products
                             where p.Price < 500
                             orderby p.Price descending
                             select p;*/

/*var query = products
    .Where(p => p.Price < 500)
    .OrderBy(p => p.Price)
    .Select(p => new { 
        Name = p.Name,
        Price = p.Price
    });// Щоб витягнути дані які потрібні з об'єкта

foreach (var product in query)
{
    Console.WriteLine(product);
}*/

/*var query = from p in products
            where p.Price < 500
            orderby p.Name descending
            select new
            {
                p.Name,
                p.Price,
                p.Count
            };
*/

//Групування даних
/*IEnumerable<IGrouping<string, Product>> query = from p in products
                                                group p by p.Manufacturer
                                                into resut
                                                where resut.Count() > 2
                                                select resut;

foreach (IGrouping<string, Product> group in query)
{
    Console.WriteLine(group.Key);
    foreach (Product product in group)
    {
        Console.WriteLine(product);
    }
}*/


//Анонімні об'єкти 
/*var worker = new
{
    Name = "Іван",
    Age = 34,
    Position = "Developer"
};
*/

//Анонімні об'єкти в LINQ
/*var query2 = from p in products
             where p.Price < 500
             orderby p.Price descending
             select new
             {
                 Назва = p.Name,
                 Виробник = p.Manufacturer
             };*/


//порахуваная кількості елементів
/*int count = products.Count(p => p.Price > 1000);
Console.WriteLine(count);*/

//повернення максимального значення
/*int maxPrice = products.Max(p => p.Price);
Console.WriteLine(maxPrice);*/


//Вивести інформацію про найдорожчий товар
/*var mostExpensiveProduct = products
    .OrderByDescending(p => p.Price)
    .FirstOrDefault();

if (mostExpensiveProduct != null)
{
    Console.WriteLine("Найдорожчий товар:");
    Console.WriteLine(mostExpensiveProduct);
}*/

int maxPrice = products.Max(p => p.Price);
Console.WriteLine(maxPrice);

// Вивсети інформацію про товар, в якого найбільша ціна

var query = products.First(p => p.Price == maxPrice);

Console.WriteLine(query);

//foreach (var product in query)
//{
//    Console.WriteLine(product);
//}


int s = products.Sum(p => p.Price);
Console.WriteLine(s);
