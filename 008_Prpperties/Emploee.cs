namespace _008_Prpperties
{
    class Employee
    {
        private string name;
        private string lastName;
        private uint age;
        private float salary;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 3)
                    name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 2)
                    lastName = value;
            }
        }

        public uint Age
        {
            get
            {
                return age;
            }
            set
            {
                if (0 <= value && value <= 120)
                    age = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (0 <= value)
                    salary = value;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name} | Surname: {lastName} | Age: {age} | Salary: {salary} ");

        }
    }
}
