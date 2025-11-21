using _011_OperatorsOverloading;

//++ - інкремент; ---декремент;
//постфіксний оператор ++/--;
/*a++;*/
//префіксний оператор ++/--;
/*++a;*/


//Перевантаженя бінарних операторів + та -:
/*MyClass obj1 = new MyClass { X = 10 };
MyClass obj2 = new MyClass { X = 20 };

MyClass obj3 = obj1 + obj2;
Console.WriteLine($"X: {obj3.X}");
MyClass obj4 = obj1 - obj2;
Console.WriteLine($"X: {obj4.X}");

MyClass obj5 = obj1 += obj2;*/

//Перевантаження оператора []:
/*MyArray array = new()
{
    Arr = [1, 2, 3]
};
array.Print();
Console.WriteLine(array.Length);
*/

/*Student student = new Student { Name = "Tom", Age = 20 };
Console.WriteLine(student);*/


Group group = new Group(new Student[]
{
    new Student { Name = "Tom", Age = 20 },
    new Student { Name = "Bob", Age = 22 },
    new Student { Name = "Alice", Age = 19 }
});

Console.WriteLine(group);
Console.WriteLine(group[2]);

//Проєкція:
/*string[] names = { "Tom", "Bob", "Alice" };
int[] arr = names.Select(s => s.Length).ToArray();
Console.WriteLine(string.Join(", ", arr));*/


/*Student[]  = new Student[]
{
    new Student { Name = "John", Age = 20},
    new Student { Name = "Den", Age = 25},
    new Student { Name = "Jack", Age = 21},
};

string[] studentsStr = students
    .Select(s => s.ToString() + "\n").ToArray();

Console.WriteLine(string.Join(",", studentsStr));*/