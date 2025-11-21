using _012_Exceptions;
using System.ComponentModel.Design;
Console.ForegroundColor = ConsoleColor.DarkGreen;

/*try //потенційно небезпечний код ми поміщаємо в блок try
{
    Console.WriteLine($"Before exception");
    throw new Exception("Test exception");
    Console.WriteLine($"After exception");
}


catch (Exception ex) //обробка виняткових ситуацій якщо виникне помилка
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine($"In finally block");
}*/


/*do
{

    try
    {
        Console.Write("Enter first: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a < 50) {
            throw new Exception("Our number is too small"); //створення власного винятку
        }

        Console.Write("Enter second: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int res = a / b;

        Console.WriteLine($"Res: {res}");
    }
    catch (DivideByZeroException ex) //той клас винятку який ми очікуємо
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    catch (Exception ex) //має завжди бути останнім
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    Console.WriteLine();

} while (true);*/


//Завдання:
//створення власного класу винятку (class: Account, Bank, NotFoundAccountException)
/*List<Account> accounts = new List<Account>()
{
    new Account { Id = 1, Name = "John", Surname = "Doe", Balance = 1000 },
    new Account { Id = 2, Name = "Jane", Surname = "Smith", Balance = 2000 },
    new Account { Id = 3, Name = "Bob", Surname = "Johnson", Balance = 3000 }
};

Bank bank = new Bank(accounts);

Account acc = new Account {
    Id = 4,
    Name = "Alice",
    Surname = "Williams", 
    Balance = 4000 
};

try
{
    bank.Withdraw(acc, 500);
}
catch (NotFoundAccountException ex)
{
    Console.Write($"Error: {ex.Message} | -> ID: {ex.Account.Id}");
}*/


//Додаткове завдання: (Enum, switch expression, exception)
/*try
{
    Console.Write("Enter first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine($"0 = +, 1 = -, 2 = *, 3 = /");
    Console.Write("Operation number: ");
    char choice = Convert.ToChar(Console.ReadLine());

    Operation operation = (Operation)choice;


    int res = operation switch
    {
        Operation.Add => a + b,
        Operation.Subtract => a - b,
        Operation.Multiply => a * b,
        Operation.Divide => a / b,
        _ => 0 //умовний дефолтний випадок
    };

    switch (operation)
    {
        case Operation.Add:
            Console.Write("Додавання: ");
            Console.WriteLine(res);
            break;
        case Operation.Subtract:
            Console.Write("Віднімання: ");
            Console.WriteLine(res);
            break;
        case Operation.Multiply:
            Console.Write("Множення: ");
            Console.WriteLine(res);
            break;
        case Operation.Divide:
            Console.Write("Ділення: ");
            Console.WriteLine(res);
            break;
        default:
            Console.WriteLine("Невідома операція");
            break;
    }
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}*/