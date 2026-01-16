namespace _028_Events_StudentExam
{
    using System;

    class Parent
    {
        public string Name { get; set; }
        public Parent(string name)
        {
            Name = name;
        }

        public void Subscribe(Student student)
        {
            student.SessionFinished += Reaction;
        }

        private void Reaction(object sender, EventArgs e)
        {
            Student student = (Student)sender;

            double marks = student.Average_Mark;

            if (marks < 7)
                Console.WriteLine($"{Name}: Aangry");
            else if (marks < 9)
                Console.WriteLine($"{Name}: Good");
            else
                Console.WriteLine($"{Name}: Money");
        }
    }


}
