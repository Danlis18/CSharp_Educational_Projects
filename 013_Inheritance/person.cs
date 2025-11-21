using System.Security.Cryptography;

namespace _013_Inheritance
{
    class Person //sealed-неможна наслідувати цей клас
    {
        //protected string Name { get; set; } //у program.cs немає доступу, тоді як у Employee.cs є

        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
