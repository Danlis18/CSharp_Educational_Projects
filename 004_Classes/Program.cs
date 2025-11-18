// Класи


using _004_Classes;

//Class Student
/*Student student = new Student();

student.SetName("John");
student.SetSurname("Smith");
student.SetAge(20);

student.Print();

Student student2 = new Student("Den", "Brown", 30);
student2.Print();*/


//Class Bank
/*Bank bank1 = new Bank();
Bank bank2 = new Bank();

bank1.Deposit(2000);
bank2.Credit(3000);

Console.WriteLine(Bank.GetBalance());*/


//Метод (ref)
/*void Method1(int a, ref int[] arr)
{
    arr[0] = 1000;
    a = 1000;
    Console.WriteLine("In Methood1");
}
int a = 10;
int[] arr = { 1, 2, 3, };
Method1(a, ref arr);

Console.WriteLine(a);
Console.WriteLine(string.Join(", ", arr));*/


//Метод (out) - вихідний пераметр
/*void Method2(out int a)
{
    a = 1000;
}

int a;

Method2(out a);
Console.WriteLine(a);*/


//
MyClass myClass = new MyClass();
myClass.Method1();
myClass.Method2();