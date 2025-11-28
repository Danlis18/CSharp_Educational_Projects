using _018_PracticeStandartInterface;


Bank clients = new Bank();

Console.WriteLine(new string('+', 10) + " список клієнтів " + new string('+', 10) + "\n");
for (int i = 0; i < clients.Length; i++)
{
    Console.WriteLine(clients[i]);
}

//clients.Sort(new AccountBalanceComparer());
clients.Sort(); //Сортування за замовчуванням (за прізвищем)

Console.WriteLine();
Console.Write(new string('+', 10) + " Посортований список клієнтів " + new string('+', 10) + "\n");

for (int i = 0; i < clients.Length; i++)
{
    Console.WriteLine(clients[i]);
}






//Приклад клонування об'єктів за допомогою інтерфейсу ICloneable
Account account = new Account
{
    FirstName = "John",
    LastName = "Miller",
    Balance = 0.00m,
    OpenedDate = DateTime.Now
};

Account account2 = (Account)account.Clone();
account2.FirstName = "Mike";
account2.Balance = 100.00m;

Console.WriteLine(account);
Console.WriteLine(account2);