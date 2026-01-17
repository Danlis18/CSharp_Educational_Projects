using _035_LINQ_PRACTICE2;

//Homework
void PrintResults<T>(IEnumerable<T> items, string text)
{
    Console.WriteLine($"----- {text} -----");
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
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
PrintResults(result1, "Employees in Ukraine (not Lviv)");

//2. Вивести список країн без повторень.
var result2 = departments
    .Select(d => d.Country)
    .Distinct();
PrintResults(result2, "Distinct Countries");

//3. Вибрати 3-x перших співробітників, вік яких перевищує 25 років.
var result3 = employees
    .Where(e => e.Age > 25)
    .Take(3);
Console.WriteLine("----- First 3 Employees over 25 -----");
foreach (var e in result3)
{
    Console.WriteLine($"{e.FirstName} {e.LastName} - {e.Age}");
}
Console.WriteLine();

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
PrintResults(result4, "Employees in Kyiv (over 23)");

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
PrintResults(result5, "Employees by Age (Descending)");

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
PrintResults(result6, "Employees in Ukraine (by Name)");

//7. Згрупувати співробітників за віком. Вивести вік і скільки разів він зустрічається в списку.
var result7 = employees
    .GroupBy(e => e.Age)
    .Select(g => new
    {
        Age = g.Key,
        Count = g.Count()
    });
PrintResults(result7, "Employees by Age");

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
foreach (var group in result8)
{
    Console.WriteLine($"Country: {group.Country}, Count: {group.Count}");
    foreach (var emp in group.Employees)
    {
        Console.WriteLine($" - {emp.FirstName} {emp.LastName}");
    }
}
Console.WriteLine();

//9. Знайти середній вік всіх співробітників.
Console.WriteLine("----- Average Age -----");
var result9 = employees.Average(e => e.Age);
Console.WriteLine($"Result: {Math.Round(result9, 1)}");
Console.WriteLine();

//10. Знайти кількість співробітників, що працюють в Україні.
Console.WriteLine("----- Employees in Ukraine -----");
var result10 = employees.Count(e => e.DepId == 1);
Console.WriteLine($"Number of employees: {result10}");
Console.WriteLine();
