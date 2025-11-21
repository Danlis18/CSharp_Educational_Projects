namespace _013_Inheritance
{
    internal class Employee : Person
    {
        public Employee()
        {
        }

        public Employee(string name, int age, double salary) : base(name, age)
        {
            this.Salary = salary;

            base.Name = name; //base - звернення до батьківського класу
        }

        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Position: {Position}, Salary: {Salary}";
        }
    }
}
