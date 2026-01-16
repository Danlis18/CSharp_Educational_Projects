namespace _028_Events_StudentExam
{
    using System;

    class Student
    {
        public string Name { get; set; }
        public int[] Points { get; set; }

        public double Average_Mark
        {
            get
            {
                double sum = 0;
                foreach (var p in Points)
                    sum += p;
                return sum / Points.Length;
            }
        }

        public event EventHandler SessionFinished;

        public Student(string name)
        {
            Name = name;
            Points = new int[10];
        }

        public void Session()
        {
            Random random = new Random();

            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = random.Next(1, 12);
            }

            Console.WriteLine($"{Name}, average mark: {Average_Mark}");
            
            SessionFinished?.Invoke(this, EventArgs.Empty);
        }
    }

}
