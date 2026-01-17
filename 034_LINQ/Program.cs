using _034_LINQ2;
using System.Text.RegularExpressions;

//string[] countries = { "Albania", "UK", "Ukraine",
//                                "Lithuania", "Andorra", "Austria",
//                                "Latvia", "Liechtenstein", "Switzerland",
//                                "Ireland", "Sweden","Italy", "France",
//                                "Liechtenstein", "Spain", "Turkey", "Germany",
//                                "Switzerland", "Monaco", "Montenegro",
//                                "Norway", "Finland", "Turkey", "UK", "Poland",
//                                "Portugal", "Lithuania", "Luxembourg"
//                                };



//// джерело даних
//List<Product> products = new List<Product>();


////генеруємо список із 100 випадкових об'єктів
//for (int i = 1; i < 100; i++)
//{
//    // Sleep() потрібен, щоб компілятор на кожній
//    // ітерації створював новий об'єкт Random,
//    // інакше, компілятор використовує
//    // оптимізацію і не змінює об'єкт Random для
//    // всіх ітерацій
//    Thread.Sleep(20);
//    products.Add(new Product
//    {
//        Name = "Product" + (i),
//        Price = (new Random()).Next(0, 1000),
//        Manufacturer =
//    countries[(new Random()).
//    Next(0, countries.Length - 1)],
//        Count = (new Random()).Next(0, 10)
//    });
//}


//Console.WriteLine("All products:");
//foreach (var item in products)
//{
//    Console.WriteLine(item);
//}


//var query = from p in products
//                    where p.Price < 500
//                    orderby p.Name descending
//                    select new {
//                        p.Name,
//                        p.Price,
//                        p.Count
//                    };


//var query = products
//    .Where(p => p.Price < 500)
//    .OrderByDescending(p => p.Price)
//    .Select(p => new {
//        Title = p.Name,
//        Price = p.Price
//    });



//foreach (var product in query)
//{
//    Console.WriteLine(product);
//}



// Анонімні об'єкти

//int a; 
//a = 10;


// var a = 5;

//var worker = new
//{
//    FirstName = "John",
//    LastName = "Smith",
//    Salary = 1000.11
//};

//Console.WriteLine(worker.FirstName);
//Console.WriteLine(worker.LastName);


//IEnumerable<IGrouping<string, Product>> query = from p in products
//                                                group p by p.Manufacturer
//                                                into resut
//                                                where resut.Count() > 2
//                                                select resut;


//foreach (IGrouping<string, Product> group in query)
//{
//    Console.WriteLine(group.Key); // Manufacturer
//    foreach (Product product in group)
//    {
//        Console.WriteLine(product);
//    }
//}



//int count = products.Count(p => p.Price > 700);
//Console.WriteLine(count);


//int maxPrice = products.Max(p => p.Price);
//Console.WriteLine(maxPrice);

//// Вивсети інформацію про товар, в якого найбільша ціна

//// var query = products.First(p => p.Price == maxPrice);
//var query = products.First(p => p.Price == products.Max(p => p.Price));

//Console.WriteLine(query);

//foreach (var product in query)
//{
//    Console.WriteLine(product);
//}


//int s = products.Sum(p => p.Price);
//Console.WriteLine(s);


//double res = products
//    .Where(p => p.Name.Length > 10)
//    .Average(p => p.Price);
//Console.WriteLine(res);



List<Group> groups = new List<Group>{
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
            };



//var query = from student in students
//            select student;

//foreach (var s in query)
//{
//    Console.WriteLine(s);
//}


// join

//var query = from g in groups
//            join s in students on g.Id
//            equals s.GroupId
//            where s.FirstName == "aaa"
//            select new
//            {
//                FirstName = s.FirstName,
//                LastName = s.LastName,
//                GroupName = g.Name
//            };

//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}


//var query = from s in students
//            join g in groups on s.GroupId
//            equals g.Id
//            select new
//            {
//                FirstName = s.FirstName,
//                LastName = s.LastName,
//                GroupName = g.Name
//            };

//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}


var query = groups
    .Where(g => g.Name == "aaaa")
    .Join(
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

//foreach (var item in query)
//{
//    Console.WriteLine(item);
//}


//var query = groups.GroupJoin(
//    students,
//    g => g.Id,
//    s => s.GroupId,
//    (group, students) => new
//    {
//        Name = group.Name,
//        Students = students.Select(s => new {
//            s.FirstName,
//            s.LastName,
//            s.Age,
//            s.Languages
//        }),
//    }
//    );


//foreach (var group in query)
//{
//    Console.WriteLine(new string('-', 100));
//    Console.WriteLine(group.Name);
//    Console.WriteLine(new string( '-', 100));
//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"{student.FirstName} {student.LastName}");
//        foreach (var l in student.Languages)
//        {
//            Console.WriteLine(l);
//        }
//    }
//}



