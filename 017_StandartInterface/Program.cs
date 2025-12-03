using _017_StandartInterface;

/*Auditory auditory = new Auditory();

Console.WriteLine(new string('+', 10) + " список студентів " + new string('+', 10) + "\n");
for (int i = 0; i < auditory.Length; i++)
{
    Console.WriteLine(auditory[i]);
}

auditory.Sort(new StudentCardNumberComparer());

Console.WriteLine();
Console.Write(new string('+', 10) + " Посортований список студентів " + new string('+', 10) + "\n");

for (int i = 0; i < auditory.Length; i++)
{
    Console.WriteLine(auditory[i]);
}*/

// Демонстрація роботи інтерфейсу ICloneable
/*StudentCard studentCard = new StudentCard
{
    Number = 123456,
    Series = "AB"
};

StudentCard studentCard2 = (StudentCard)studentCard.Clone();

studentCard2.Number = 654321;

Console.WriteLine(studentCard);*/

// Демонстрація роботи інтерфейсу ICloneable з класом Student
/*Student student = new Student
{
    FirstName = "John",
    LastName = "Miller",
    BirthDate = new DateTime(1997, 3, 12),
    StudentCard = new StudentCard
    {
        Number = 189356,
        Series = "AB"
    }
};

Student student2 = (Student)student.Clone();
student2.FirstName = "Mike";
student2.StudentCard.Number = 999999;
Console.WriteLine(student);*/

//Вивід за допомогою foreach

Auditory auditory = new Auditory();

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}
