using System.Collections;
namespace _017_StandartInterface
{
    class StudentbirthdayComoarer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).BirthDate.CompareTo((y as Student).BirthDate);
            }
            throw new ArgumentException("Object is not a Student");
        }
    }
}
