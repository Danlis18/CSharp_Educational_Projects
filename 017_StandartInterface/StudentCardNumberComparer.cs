using System.Collections;
namespace _017_StandartInterface
{
    internal class StudentCardNumberComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Student && y is Student)
            {
                return (y as Student).StudentCard.Number.CompareTo((x as Student).StudentCard.Number);
            }
            throw new ArgumentException("Object is not a Student");
        }
    }
}
