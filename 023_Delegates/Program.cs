using _023_Delegates;
//Делегати - це об'єкти, які посилаються на методи і дозволяють викликати ці методи через делегати.

//Використовується для:
// - передачі методів як пераметрів інших меодів
// - є основою для подій і зворотних викликів


//Приклад - 1:
/*MyClass myClass = new MyClass();
MyDelegate myDelegate = new MyDelegate(myClass.Method);
myDelegate();
myDelegate = myClass.AnotherMethod;
myDelegate();*/


//Завдання:
/*Messenger messenger = new Messenger();
MessageDelegate messageDelegate = new MessageDelegate().print_sms;
messageDelegate("Danylo");*/


//Приклад - 2:
/*Person[] peopleArray = new Person[]
{
            new Person("Charlie", 45),
            new Person("Diana", 19),
            new Person("Bob", 30),
            new Person("Edward", 52),
            new Person("Alice", 25),
            new Person("Jack", 33),
            new Person("Ivy", 49),
            new Person("Fiona", 38),
            new Person("George", 65),
            new Person("Hannah", 21),
};

Console.WriteLine("Person Array initialized using collection initializer:");
foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}

void SortPeople(Person[] people, ComparerDelegate comparerDelegate)
{
    int n = people.Length;
    bool swapped; 

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;

        for (int j = 0; j < n - 1 - i; j++)
        {
            if (comparerDelegate(people[j], people[j + 1])) //застосовуємо делегат, для того щоб знати по чому порівнювати
            {
                Person temp = people[j];
                people[j] = people[j + 1];
                people[j + 1] = temp;

                swapped = true;
            }
        }

        if (swapped == false)
        {
            break;
        }
    }
}*/

//Порівння по віку
/*bool CompareByAge(Person person1, Person person2)
{
    return person1.Age > person2.Age;
}
SortPeople(peopleArray, CompareByAge);*/

//Порівння по імені
/*bool CompareByName(Person person1, Person person2)
{
    return person1.Name.CompareTo(person2.Name) == -1;
}
SortPeople(peopleArray, CompareByName);


foreach (Person person in peopleArray)
{
    Console.WriteLine(person.ToString());
}*/


//Приклад - 3:
/*MyClass myClass = new MyClass();
MyDelegate del = new MyClass().Method;

del += myClass.AnotherMethod; //додаємо новий метод в комлецію
del -= myClass.Method;  //віднімаємо метод з колекції

del();*/


//Приклад - 4: (Generic Delegate)
/*int Plus(int a, int b)
{
    return a + b;
}
int Multiply(int a, int b)
{
    return a * b;
}  
double PlusDouble(double a, double b)
{
    return a + b;
}

string AddString(string s1, string s2) {  
    return s1 + s2; 
}

OperationDelegate<int> operationDelegatePlus = Plus;
int resP = operationDelegatePlus(4, 6);
OperationDelegate<int> operationDelegateMultiply = Multiply;
int resM= operationDelegateMultiply(5, 5);
OperationDelegate<double> operationDelegateDoubleAdd = PlusDouble;
double resDP = operationDelegateMultiply(10, 5);
OperationDelegate<string> operationDelegateString = AddString;
string resSP = operationDelegateString("qa", "32");
*/



//Готові Delegate в .NET

//Action<T>
//public delegate void Action<in T>(T obj);

//Func<T, TResult>
//public delegate TResult Func<in T, out TResult>(T arg);

//Predicate<T>
//public delegate bool Predicate<in T>(T obj);

//Comparison<T>
//public delegate int Comparison<in T>(T x, T y);