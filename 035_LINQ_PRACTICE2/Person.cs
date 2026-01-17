namespace _035_LINQ_PRACTICE2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}, {City}";
        }
    }
}
