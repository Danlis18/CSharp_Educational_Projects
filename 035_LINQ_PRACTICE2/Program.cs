using _035_LINQ_PRACTICE2;



/*List<Person> person = new List<Person>()
{
    new Person(){ Name = "Andriy", Age = 24, City = "Kyiv" },
    new Person(){ Name = "Marta", Age = 18, City = "Madrid" },
    new Person(){ Name = "Oleg", Age = 15, City = "London" },
    new Person(){ Name = "Anna", Age = 55, City = "Kyiv" },
    new Person(){ Name = "Anna", Age = 32, City = "Kyiv" }
};


static void PrintResults<T>(IEnumerable<T> items)
{
    foreach (var item in items)
        Console.WriteLine(item);

    Console.WriteLine("-----");
}

//1.Вибрати людей, старших 25 років.
var result1 = person.Where(p => p.Age > 25);
PrintResults(result1);   

// 2. Вибрати людей, які проживають не в Києві.
var result2 = person.Where(p => p.City != "Kyiv");
PrintResults(result2);

// 3. Вибрати імена людей, які проживають в Києві.
var result3  = person
    .Where(p => p.City == "Kyiv")
    .Select(p => p.Name);
foreach (var name in result3)
{
    Console.WriteLine(name);
}
// 4. Вибрати людей старших за 35 років з ім'ям Anna.
var result4 = person.Where(p => p.Age > 35 && p.Name == "Anna");
PrintResults(result4);

// 5. Вибрати людей, які проживають в Лондоні.
var result5 = person.Where(p => p.City == "London");
PrintResults(result5);


// 6. Найстарший вік
int result6 = person.Max(p => p.Age);
Console.WriteLine($"Max age: {result6}");

// 7. Посортувати по імені за спаданням і взяти тільки ім'я та вік
var result7 = person
    .OrderByDescending(p => p.Name)
    .Select(p => new { p.Name, p.Age });

PrintResults(result7);

// 8. Наймолодша людина 
var result8 = person
    .OrderBy(p => p.Age)
    .FirstOrDefault();
    
if (result8 != null)
    Console.WriteLine($"Youngest: {result8.Name}, {result8.Age} ({result8.City})");

// 9. Згрупувати людей по місту
var result9 = person
    .GroupBy(p => p.City)
    .OrderBy(g => g.Key);

foreach (var group in result9)
{
    Console.WriteLine($"\nCity: {group.Key} (count: {group.Count()})");
    PrintResults(group);
}

// 10. Імена людей та кількість букв в імені
var result10 = person
    .Select(p => new { p.Name, LetterCount = p.Name.Length });

PrintResults(result10);
*/


/*List<Group> groups = new List<Group>{
                new Group {
                    Id = 1,
                    Name = "27PPS11"
                },
                new Group {
                    Id = 2,
                    Name = "27PPS12"
                }
            };


List<Student> students = new List<Student>
            {
                new Student {
                    FirstName = "John",
                    LastName = "Miller",
                    Age = 21,
                    Languages = new List<string> {"Ukrainian", "English", "Polish" },
                    GroupId = 1
                },
                new Student {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Age = 22,
                    Languages = new List<string> {"English", "French", "Spanish" },
                    GroupId = 2
                },
                new Student {
                    FirstName = "Joey",
                    LastName = "Finch",
                    Age = 20,
                    Languages = new List<string> {"Ukrainian", "Spanish", "English", "Deutsch" },
                    GroupId = 3
                },
                new Student {
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    Age = 19,
                    Languages = new List<string> {"Ukrainian", "Deutsch", "Italian" },
                    GroupId = 1
                },
                 new Student {
                    FirstName = "Ariana",
                    LastName = "Clark",
                    Age = 21,
                    Languages = new List<string> {"Deutsch", "Japanese" },
                    GroupId = 2
                }
            };*/

/*var query = from student in students
            select student;*/

// join
/*var query = from g in groups
            join s in students on g.Id
            equals s.GroupId
            select new
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                GroupName = g.Name
            };*/


/*var query = groups.Join(
    students,
    g => g.Id,
    s => s.GroupId,
    (g, s) => new
    {
        FirstName = s.FirstName,
        LastName = s.LastName,
        GroupName = g.Name
    }
);

foreach (var item in query)
{
    Console.WriteLine(item);
}*/

/*var query = groups.GroupJoin(
    students,
    g => g.Id,
    s => s.GroupId,
    (group, students) => new
    {
        Name = group.Name,
        Students = students.Select(s => new {
            s.FirstName,
            s.LastName,
            s.Age,
            s.Languages
        }),
    }
    );

foreach (var group in query)
{
    Console.WriteLine(new string('-', 100));
    Console.WriteLine(group.Name);
    Console.WriteLine(new string('-', 100));
    foreach (var student in group.Students)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName}");
        foreach (var l in student.Languages)
        {
            Console.WriteLine(l);
        }
    }
}*/




//Homework
void PrintResults<T>(IEnumerable<T> items)
{
    foreach (var item in items)
        Console.WriteLine(item);
    Console.WriteLine("-----");
}

List<Department> departments = new List<Department>()
{
    new Department(){ Id = 1, Country = "Ukraine", City = "Lviv" },
    new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
    new Department(){ Id = 3, Country = "France", City = "Paris" },
    new Department(){ Id = 4, Country = "Italy", City = "Rome" }
};

List<Employee> employees = new List<Employee>()
{
    new Employee()
        { Id = 1, FirstName = "Tamara", LastName = "Shevchuk", Age = 24, DepId = 2 },
    new Employee() 
    { Id = 2, FirstName = "Vasyl", LastName = "Latyk", Age = 33, DepId = 1 },
    new Employee()
        { Id = 3, FirstName = "Anna", LastName = "Shevchuk ", Age = 43, DepId = 3 },
    new Employee()
        { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
    new Employee()
        { Id = 5, FirstName = "Maria", LastName = "Voron", Age = 36, DepId = 4 },
    new Employee()
        { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
    new Employee()
        { Id = 7, FirstName = "Vasyl", LastName = " Shevchuk", Age = 27, DepId = 4 }
};



//1. Вибрати імена та прізвища співробітників, які працюють в Україні, але не у Львові.
var result1 = from emp in employees
              join dep in departments on emp.DepId equals dep.Id
              where dep.Country == "Ukraine" && dep.City != "Lviv"
              select new
              {
                  emp.FirstName,
                  emp.LastName
              };
PrintResults(result1);

//2. Вивести список країн без повторень.
var result2 = departments
    .Select(d => d.Country)
    .Distinct();
PrintResults(result2);

//3. Вибрати 3-x перших співробітників, вік яких перевищує 25 років.
var result3 = employees
    .Where(e => e.Age > 25)
    .Take(3);
PrintResults(result3);

//4. Вибрати імена, прізвища та вік студентів з Києва, вік яких перевищує 23 роки.
var result4 = from emp in employees
              join dep in departments on emp.DepId 
              equals dep.Id
              where dep.City == "Kyiv" && emp.Age > 23
              select new
              {
                  emp.FirstName,
                  emp.LastName,
                  emp.Age
              };
PrintResults(result4);

//5. Відсортувати співробітників по віковим групам, по спаданню. Вивести Id, FirstName, LastName, Age.
var result5 = employees
    .OrderByDescending(e => e.Age)
    .Select(e => new
    {
        e.Id,
        e.FirstName,
        e.LastName,
        e.Age
    });
PrintResults(result5);

//6. Відсортувати по імені за алфавітом співробітників, які проживають в Україні. Вибрати імена, прізвища, місто.
var result6 = from emp in employees
              join dep in departments on emp.DepId equals dep.Id
              where dep.Country == "Ukraine"
              orderby emp.FirstName
              select new
              {
                  emp.FirstName,
                  emp.LastName,
                  dep.City
              };
PrintResults(result6);

//7. Згрупувати співробітників за віком. Вивести вік і скільки разів він зустрічається в списку.
var result7 = employees
    .GroupBy(e => e.Age)
    .Select(g => new
    {
        Age = g.Key,
        Count = g.Count()
    });
PrintResults(result7);

//8. Згрупувати співробітників по країні. У кожній групі співробітники повинні бути відсортовані за іменем. Вивести країну, співробітників і скільки разів вони зустрічаються в країні.
var result8 = from emp in employees
              join dep in departments on emp.DepId equals dep.Id
              group emp by dep.Country into g
              select new
              {
                  Country = g.Key,
                  Employees = g.OrderBy(e => e.FirstName),
                  Count = g.Count()
              };
PrintResults(result8);

//9. Знайти середній вік всіх співробітників.
var result9 = employees.Average(e => e.Age);
Console.WriteLine($"Average age: {result9}");

//10. Знайти кількість співробітників, що працюють в Україні.
var result10 = employees.Count(e => e.DepId == 1);
Console.WriteLine($"Number of employees in Ukraine: {result10}");
