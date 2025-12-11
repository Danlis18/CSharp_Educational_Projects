using _024_DelegatesPractice;
using System;

//Завдання 1
/*void FullNameUpper(Student student)
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
*/

//Завдання 2
/*List<int> MyFindAll(List<int> elements, MyPredicate<int> predicate)
{
    List<int> result = new List<int>();

    foreach (int element in elements)
    {
        if (predicate(element))
        {
            result.Add(element);
        }
    }

    return result;
}
bool OnlyEven(int item)
{
    return item % 2 == 0;
}

void MyForeach<T>(List<T> elements, MyPredicate<T> predicate)
{
    foreach (var element in elements)
    {
        bool result = predicate(element);
        Console.WriteLine($"{element}: {result}");
    }
}

List<int> elements = new List<int>
{
    332, 31, -432, 53
};


MyPredicate<int> Only_Even = OnlyEven;
MyForeach(elements, Only_Even);

Console.WriteLine();
Console.WriteLine("New List, only even:");
List<int> result = MyFindAll(elements, Only_Even);
foreach (var item in result)
{
    Console.WriteLine(item);
}*/


