
namespace _018_PracticeStandartInterface
{
    class Account : IComparable, ICloneable
    {
        private string accountNumber;
        private string firstName;
        private string lastName;
        private decimal balance;
        private DateTime openedDate;

        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public DateTime OpenedDate { get; set; }


        public object Clone()
        {
            Account clonedAccount = (Account)this.MemberwiseClone();
            //clonedAccount.LastName = this.LastName.Clone() as Account;
            return clonedAccount;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Account)
            {
                Account other = (Account)obj;
                return this.LastName.CompareTo(other.LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Account: {AccountNumber}, {FirstName} {LastName}, Balance: {Balance}, Opened: {OpenedDate.ToShortDateString()}";
        }
    }
}
