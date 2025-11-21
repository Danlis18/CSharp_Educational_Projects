using System.Security.Principal;

namespace _012_Exceptions
{
    class Bank
    {
        List<Account> accounts;

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
        }

        public void Withdraw(Account account, int amount)
        {
            bool isExists = false;
            foreach (var item in accounts)
            {
                if (item.Id == account.Id)
                {
                    isExists = true;
                }
            }

            if (!isExists)
            {
                throw new NotFoundAccountException("Not Found Account", account);
            }

            account.Balance -= amount;

        }

    }
}
