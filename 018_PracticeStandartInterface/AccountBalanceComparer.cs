using System.Collections;
namespace _018_PracticeStandartInterface
{
    class AccountBalanceComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account && y is Account)
            {
                return (x as Account).Balance.CompareTo((y as Account).Balance);
            }
            throw new Exception("Object is not an Account");
        }
    }
}
