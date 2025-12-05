using System.Collections;
namespace _022_Collections
{
    class Person : IComparable
    {
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Person)
            {
                Person other = (Person)obj;
                return this.LastName.CompareTo(other.LastName);
            }
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"LastName: {LastName}, Age: {Age}";
        }
    }
}
