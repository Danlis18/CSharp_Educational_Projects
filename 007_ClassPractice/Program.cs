using _007_ClassPractice;
using Figures2D;


//Завдання 2:
Circle circle = new Circle(new Point(2, 4), 32);
Console.WriteLine(circle);

Console.WriteLine();
Console.WriteLine("-----------------------");
Console.WriteLine();

//Завдання 3:
Car[] cars =
    {
        new Car("BMW", "X5", 2020, "red", "Danilo"),
        new Car("Tesla", "Model 3", 2000, "green", "Kilo"),
        new Car("Audi", "A4", 2018, "purple", "Askolin"),
        new Car("Nissan", "Leaf", 2019, "blue", "Binoklin"),
        new Car("Mercedes", "C-Class", 1990,"white", "Wertiko")
    };

foreach (var car in cars)
{
    Console.WriteLine(car);
    double price;
    int valueOfOwners;
    car.CalculatePrice(out price, out valueOfOwners);
    Console.WriteLine($"Цiна: {price} | Kiдькiсть власникiв: {valueOfOwners}\n");
}

Console.WriteLine($"Загальна кiлькiсть автомобiлiв: {Car.TotalCars}");