using System.Collections;
namespace _018_PracticeStandartInterface
{
    class Bank
    {
        Account[] accounts =
        {
            new Account {
                            AccountNumber ="ACC123",
                            FirstName ="John",
                            LastName ="Doe",
                            Balance =1500.75m,
                            OpenedDate =new DateTime(2020,1,15)
                        },
            new Account {
                            AccountNumber ="ACC456",
                            FirstName ="Jane",
                            LastName ="Smith",
                            Balance =2500.00m,
                            OpenedDate =new DateTime(2019,6,30)
                        },
            new Account {
                            AccountNumber ="ACC789",
                            FirstName ="Alice",
                            LastName ="Johnson",
                            Balance =3200.50m,
                            OpenedDate =new DateTime(2021,3,10)
                        },
            new Account {
                            AccountNumber ="ACC012",
                            FirstName ="Bob",
                            LastName ="Brown",
                            Balance =1800.25m,
                            OpenedDate =new DateTime(2018,11,5)
                        }
        };

        public int Length
        {
            get { return accounts.Length; }
        }

        public Account this[int index]
        {
            get { return accounts[index]; }
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(accounts, comparer);
        }

        internal void Sort()
        {
            throw new NotImplementedException();
        }
    }
}


