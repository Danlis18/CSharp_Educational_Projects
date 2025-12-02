using _018_PracticeStandartInterface;


Bank clients = new Bank();
void print(Bank clients) {
   Console.WriteLine();
   Console.WriteLine(new string('+', 10) + " список клiєнтiв " + new string('+', 10));
    for (int i = 0; i < clients.Length; i++)
    {
        Console.WriteLine(clients[i]);
    }
}

print(clients);

clients.Sort(); //Сортування за замовчуванням (за прізвищем)

print(clients);

clients.Sort(new AccountBalanceComparer()); //Сортування за балансом

print(clients);

clients.Sort(new AccountRegistrationCompare()); //Сортування за датою реєстрації

print(clients);



//Приклад клонування об'єктів за допомогою інтерфейсу ICloneable
Account account = new Account
{
    FirstName = "John",
    LastName = "Miller",
    AccountNumber = "QWERTY",
    Balance = 0.00m,
    OpenedDate = DateTime.Now
};

Account account2 = (Account)account.Clone();
account2.FirstName = "Mike";
account2.Balance = 100.00m;

Console.WriteLine();
Console.WriteLine(account);
Console.WriteLine(account2);