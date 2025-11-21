using Lab_OperatorsOverloading;

Shop shop = new Shop(new Laptop[]
{
    new Laptop { Vendor = "Lenovo", Price = 20000.0 },
    new Laptop { Vendor = "HP", Price = 25000.0 },
    new Laptop { Vendor = "Dell", Price = 30000.0 }
});

Console.WriteLine(shop);
Console.WriteLine(shop[2]);
Console.WriteLine(shop["HP"]);
Console.WriteLine(shop[25000.0]);

