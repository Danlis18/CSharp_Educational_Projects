using System.Collections;
namespace _022_Collections
{
    class PersonAgeComoarer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Person && y is Person)
            {
                return (x as Person).Age.CompareTo((y as Person).Age);
            }
            throw new ArgumentException("Object is not a Student");
        }
    }

}
