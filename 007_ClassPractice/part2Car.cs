using System.Reflection;

namespace _007_ClassPractice
{
    partial class Car
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"{brand} {name} ({year})");
        }
    }
}
