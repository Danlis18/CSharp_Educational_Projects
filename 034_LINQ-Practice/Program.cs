using System;
using System.Text;
Console.ForegroundColor = ConsoleColor.Green;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string[] cars = {
    "Nissan", "Chevrolet", "Tesla", 
    "Cadillac", "Hummer", "Alfa Romeo", 
    "Land Rover", "Chrysler", "Bentley",
    "Renault", "Suzuki", "Honda",
    "Dodge", "BMW", "Ferrari",
    "Audi", "Hyundai", "Skoda",
    "KIA", "Bugatti","Bentley",
    "SEAT", "Maserati", "Ford",
    "Buick", "Lexus", "Mercedes",
    "Toyota", "Lincoln", "Volvo",
    "Aston Martin", "Fiat", "Subaru",
    "Maybach", "Infiniti", "Volkswagen",
    "Opel", "Citroen", "Mazda", "Jaguar",
    "Peugeot", "Dacia", "Jeep", "Lamborghini"
};
void print(IEnumerable<string> collection)
{
    foreach (var item in collection)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}


//select
/*//1. Вивести всі автомобілі.
    var allCars = from car in cars
                  select car;

    Console.WriteLine("Всі автомобілі:");
    print((IEnumerable<string>)allCars);

//2. Вивести кількості букв в назві кожного автомобіля.
var query = from car in cars select car.Length;

foreach (var car in query)
{
    Console.WriteLine(car);
}
Console.WriteLine();

//3. Доставити до кожного слова знак оклику, і вивести всі автомобілі.
var carsWithExclamation = from car in cars select car + "!";

foreach (var car in carsWithExclamation)
{
    Console.WriteLine(car);
}
Console.WriteLine();*/

//where
/*//1. Вивести всі автомобілі, назви яких закінчуються на букву ‘a’.
    var carsEndingWithA = from car in cars
                          where car.EndsWith("a")
                          select car;
    print(carsEndingWithA);

//3. Вибрати всі автомобілі, назва яких складається з 5 букв.
var carsWith5Letters = from car in cars
                           where car.Length == 5
                           select car;
    Console.WriteLine("Автомобілі з 5 буквами в назві:");
    print(carsWith5Letters);

//6. Вибрати тільки ті назви автомобілів, які мають букву ‘s’, привівши назву кожного автомобіля до верхнього реєстру
    var carsWithSUpper = from car in cars
                         where car.Contains('s') || car.Contains('S')
                         select car.ToUpper();
    Console.WriteLine("Автомобілі з буквою 's' у верхньому регістрі:");
    print(carsWithSUpper);
*/

//order by
/*// 1. Посортувати і вивести всі автомобілі по зростанню, спаданню.
    var carsAscending = from car in cars
                        orderby car ascending
                        select car;
    var carsDescending = from car in cars
                         orderby car descending
                         select car;

    Console.WriteLine("Автомобілі по зростанню:");
    print(carsAscending);
    Console.WriteLine("Автомобілі по спаданню:");
    print(carsDescending);



// 2. Посортувати і вивести всі автомобілі по зростанню по довжині слова.
    var carsByLengthAscending = from car in cars
                                orderby car.Length ascending
                                select car;
    Console.WriteLine("Автомобілі по зростанню довжини слова:");
    print(carsByLengthAscending);

// 3. Посортувати і вивести всі автомобілі, в назві яких кількість букв більше 4 по зростанню, спаданню.
    var carsMoreThan4Letters = from car in cars
                               where car.Length > 4
                               orderby car descending
                               select car;
    Console.WriteLine("Автомобілі з більше ніж 4 буквами по спаданню:");
    print(carsMoreThan4Letters);*/

//group by
/*//1.Згрупувати автомобілі по першій букві.
IEnumerable<IGrouping<char, string>> groupedCars = from car in cars
                                                   group car by car[0];
foreach (IGrouping<char, string> group in groupedCars) { 
    Console.WriteLine($"Автомобілі на букву {group.Key}:");
    print(group);
}
Console.WriteLine();

//2. Згрупувати автомобілі по першій букві посортовано по зростанню.
IEnumerable<IGrouping<char, string>> groupedCarsSorted = from car in cars
                                                           orderby car[0] ascending
                                                           group car by car[0];
foreach (IGrouping<char, string> group in groupedCarsSorted)
{   
    Console.WriteLine($"Автомобілі на букву {group.Key}:");
    print(group);
}
Console.WriteLine();

//3. Згрупувати автомобілі по кількості букв в слові.
IEnumerable<IGrouping<int, string>> groupedByLength = from car in cars
                                                       group car by car.Length;
foreach (IGrouping<int, string> group in groupedByLength)
{
    Console.WriteLine($"Автомобілі з {group.Key} буквами:");
    print(group);
}*/

//into
/*IEnumerable<IGrouping<char, string>> query = from s in cars
                                             group s by s[0]
                                             into result
                                             where result.Count() > 2
                                             select result;

foreach (IGrouping<char, string> group in query)
{
    Console.WriteLine(group.Key);
    foreach (string car in group)
    {
        Console.WriteLine(car);
    }
}*/

//1. Згрупувати автомобілі по першій букві і вивести тільки ті результати, яких більше ніж 1.
/*IEnumerable<IGrouping<char, string>> query1 = from s in cars
                                             group s by s[0]
                                             into result
                                             where result.Count() > 1
                                             select result;

foreach (IGrouping<char, string> group in query1)
{
    Console.WriteLine(group.Key);
    foreach (string car in group)
    {
        Console.WriteLine(car);
    }
}
*/

//2. Згрупувати посортовані по зростанню по назві автомобілі по кількості букв в слові і посортувати вибірку по зростанню по кількості слів.
/*IEnumerable<IGrouping<int, string>> query2 = from s in cars
                                             orderby s
                                             group s by s.Length into result
                                             orderby result.Key
                                             select result;

foreach (IGrouping<int, string> group in query2)
{
    Console.WriteLine($"Автомобілі з {group.Key} буквами:");
    foreach (string car in group)
    {
        Console.WriteLine(car);
    }
}*/

//3. Згрупувати автомобілі по першій букві використовуючи синтаксис методів.
var query = cars.GroupBy(s => s[0]);

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (string car in group)
    {
        Console.WriteLine(car);
    }
}