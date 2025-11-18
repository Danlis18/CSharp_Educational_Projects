using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Classes
{
    internal class Bank
    {
        private static int balance = 10000;

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Credit(int amount)
        {
            balance -= amount;
        }

        public static int GetBalance()
        {
            return balance;
        }
    }
}
