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

//Завдання 1:
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

//2. Вивести всі автомобілі, назви яких містять букву ‘r’.
    var carsContainingR = from car in cars
                          where car.Contains("r") || car.Contains("R")
                          select car;
    print(carsContainingR);

//3. Вибрати всі автомобілі, назва яких складається з 5 букв.
var carsWith5Letters = from car in cars
                           where car.Length == 5
                           select car;
    Console.WriteLine("Автомобілі з 5 буквами в назві:");
    print(carsWith5Letters);

//4. Вивести всі автомобілі, назви яких мають кількість букв більше 5.
var carsWithMoreThan5Letters = from car in cars
                                where car.Length > 5
                                select car;
Console.WriteLine("Автомобілі з більше ніж 5 буквами в назві:");
print(carsWithMoreThan5Letters);

//5. Вивести всі автомобілі, назви яких містять букву ‘r’ і які мають кількість букв менше 7.
var carsContainingRAndLessThan7Letters = from car in cars
                                          where (car.Contains("r") || car.Contains("R")) && car.Length < 7
                                          select car;
Console.WriteLine("Автомобілі з буквою 'r' і менше 7 буквами в назві:");
print(carsContainingRAndLessThan7Letters);

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

//2. Згрупувати посортовані по зростанню по назві автомобілі по кількості букв в слові і посортувати вибірку по зростанню по кількості слів.
IEnumerable<IGrouping<int, string>> query2 = from s in cars
                                             orderby s
                                             group s by s.Length into result
                                             orderby result.Key
                                             select result;
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
/*var query = cars.GroupBy(s => s[0]);

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (string car in group)
    {
        Console.WriteLine(car);
    }
}*/


//Завдання 2:
//select
/*//1. Вивести всі автомобілі.
var allCars = cars.Select(car => car);
Console.WriteLine("Всі автомобілі:");
print(allCars);

//2. Вивести кількості букв в назві кожного автомобіля.
var lengths = cars.Select(car => car.Length);
foreach (var len in lengths) Console.WriteLine(len);
Console.WriteLine();

//3. Доставити до кожного слова знак оклику, і вивести всі автомобілі.
var carsWithExclamation = cars.Select(car => car + "!");
foreach (var car in carsWithExclamation) Console.WriteLine(car);
Console.WriteLine();*/

//where
/*//1. Вивести всі автомобілі, назви яких закінчуються на букву ‘a’.
var carsEndingWithA = cars.Where(car => car.EndsWith("a"));
print(carsEndingWithA);

//2. Вивести всі автомобілі, назви яких містять букву ‘r’.
var carsContainingR = cars.Where(car => car.Contains('r') || car.Contains('R'));
print(carsContainingR);

//3. Вибрати всі автомобілі, назва яких складається з 5 букв.
var carsWith5Letters = cars.Where(car => car.Length == 5);
Console.WriteLine("Автомобілі з 5 буквами в назві:");
print(carsWith5Letters);

//4. Вивести всі автомобілі, назви яких мають кількість букв більше 5.
var carsWithMoreThan5Letters = cars.Where(car => car.Length > 5);
Console.WriteLine("Автомобілі з більше ніж 5 буквами в назві:");
print(carsWithMoreThan5Letters);

//5. Вивести всі автомобілі, назви яких містять букву ‘r’ і які мають кількість букв менше 7.
var carsContainingRAndLessThan7Letters =
    cars.Where(car => (car.Contains('r') || car.Contains('R')) && car.Length < 7);
Console.WriteLine("Автомобілі з буквою 'r' і менше 7 буквами в назві:");
print(carsContainingRAndLessThan7Letters);

//6. Вибрати тільки ті назви автомобілів, які мають букву ‘s’, привівши назву до верхнього реєстру
var carsWithSUpper =
    cars.Where(car => car.Contains('s') || car.Contains('S'))
        .Select(car => car.ToUpper());
Console.WriteLine("Автомобілі з буквою 's' у верхньому регістрі:");
print(carsWithSUpper);*/

//order by
/*//1. Посортувати і вивести всі автомобілі по зростанню, спаданню.
var carsAscending = cars.OrderBy(car => car);
var carsDescending = cars.OrderByDescending(car => car);

Console.WriteLine("Автомобілі по зростанню:");
print(carsAscending);

Console.WriteLine("Автомобілі по спаданню:");
print(carsDescending);

//2. Посортувати і вивести всі автомобілі по зростанню по довжині слова.
var carsByLengthAscending = cars.OrderBy(car => car.Length);
Console.WriteLine("Автомобілі по зростанню довжини слова:");
print(carsByLengthAscending);

//3. Посортувати і вивести всі автомобілі, в назві яких кількість букв більше 4 по зростанню, спаданню.
var carsMoreThan4LettersDesc =
    cars.Where(car => car.Length > 4)
        .OrderByDescending(car => car);

Console.WriteLine("Автомобілі з більше ніж 4 буквами по спаданню:");
print(carsMoreThan4LettersDesc);
*/

//group by
/*//1. Згрупувати автомобілі по першій букві.
var groupedCars = cars.GroupBy(car => car[0]);
foreach (var group in groupedCars)
{
    Console.WriteLine($"Автомобілі на букву {group.Key}:");
    print(group);
}
Console.WriteLine();

//2. Згрупувати автомобілі по першій букві посортовано по зростанню.
var groupedCarsSorted = cars
    .OrderBy(car => car[0])
    .GroupBy(car => car[0]);

foreach (var group in groupedCarsSorted)
{
    Console.WriteLine($"Автомобілі на букву {group.Key}:");
    print(group);
}
Console.WriteLine();

//3. Згрупувати автомобілі по кількості букв в слові.
var groupedByLength = cars.GroupBy(car => car.Length);
foreach (var group in groupedByLength)
{
    Console.WriteLine($"Автомобілі з {group.Key} буквами:");
    print(group);
}
*/

//into
/*var query = cars
    .GroupBy(s => s[0])
    .Where(g => g.Count() > 2);

foreach (var group in query)
{
    Console.WriteLine(group.Key);
    foreach (var car in group)
        Console.WriteLine(car);
}*/


//Завдання 3:
/*//1. Вибрати тільки перших 9 автомобілів
var first9Cars = cars.Take(9);

Console.WriteLine("Перші 9 автомобілів:");
print(first9Cars);

//3. Вибрати автомобілі поки кількість букв < 12 і ще не досягнутий 10 елемент
var carsLengthLessThan12AndMax10 =
    cars.TakeWhile(car => car.Length < 12)
        .Take(10);

Console.WriteLine("Автомобілі поки довжина < 12 і не більше 10 елементів:");
print(carsLengthLessThan12AndMax10);

//4. Вибрати 5 автомобілів, які йдуть після перших 4.
var fiveAfterFirstFour = cars.Skip(4).Take(5);

Console.WriteLine("5 автомобілів після перших 4:");
print(fiveAfterFirstFour);*/
