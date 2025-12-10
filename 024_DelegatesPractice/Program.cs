using _024_DelegatesPractice;
using System;

void FullNameUpper(Student student)
{
    Console.WriteLine($"{student.FirstName.ToUpper()} {student.LastName.ToUpper()}");
}

void Foreach(List<Student> students, MyAction<Student> myAction)
{
    foreach (var student in students)
    {
        myAction(student); 
    }
}

List<Student> students = new List<Student>
{
    new Student("John", "Smith"),
    new Student("Emma", "Johnson"),
    new Student("Michael", "Williams"),
    new Student("Sophia", "Brown"),
    new Student("James", "Jones"),
    new Student("Robert", "Davis"),
    new Student("Ava", "Garcia"),
    new Student("David", "Wilson"),
    new Student("Isabella", "Moore")
};


MyAction<Student> action = FullNameUpper;
Foreach(students, action);
