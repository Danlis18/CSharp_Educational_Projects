using System.Collections;
namespace _018_PracticeStandartInterface
{
    class AccountRegistrationCompare : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account && y is Account)
            {
                return (x as Account).OpenedDate.CompareTo((y as Account).OpenedDate);
            }
            throw new Exception("Object is not an Account");
        }
    }
}
