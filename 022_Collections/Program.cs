using _022_Collections;
using System.Collections;
//Динамічні структури даних з використанням колекцій (списки, стеки, черги)


//ArrayList
/*ArrayList arrayList = new ArrayList();
arrayList.Add(132);
arrayList.Add("Hello");
arrayList.Add(45.67);
arrayList.Add(true);
Console.WriteLine("ArrayList contents:");
foreach (object item in arrayList)
{
    Console.WriteLine(item);
}
Console.WriteLine(arrayList[0]);
int a = (int)arrayList[0];*/

/*ArrayList arrayList = new ArrayList() 
{ 
    132, 32,  54, 23, 87, -12, -45
};

arrayList.Add(2);
arrayList.AddRange(new int[] { 5, 7, 9 }); //передавємо іншу колекцію (масив, списки, черги, АрайЛіст)
arrayList.Insert(2, 100); 
arrayList.Remove(87);
arrayList.RemoveAt(4); //видалення за індексом
arrayList.Reverse();

arrayList.Sort();

foreach (var item in arrayList)
{
    Console.Write($"{item} ");
}*/

//ArrayList з об'єктами Person
/*ArrayList people = new ArrayList()
{
    new Person { LastName = "Hlice", Age = 30 },
    new Person { LastName = "Bob", Age = 25 },
    new Person { LastName = "Aharlie", Age = 35 }
};

foreach (var item in people)
{
    Console.Write($"{item} \n");
}
Console.WriteLine();

people.Sort();

foreach (var item in people)
{
    Console.Write($"{item} \n");
}
Console.WriteLine();

people.Sort(new PersonAgeComoarer());

foreach (var item in people)
{
    Console.Write($"{item} \n");
}*/


//List<int> - GENERIC
/*List<int> numbers = new List<int>()
{
    0, 1, 2, 432, 328, 809
};

numbers.AddRange(new List<int> { 111, 777, 999});
numbers.Sort((a, b) => b.CompareTo(a)); //лямда функції

foreach (int i in numbers)
{
    Console.Write($"{i}, ");
}*/


//Stack<inr> - GENERIC
/*Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);

foreach (int item in stack)
{
    Console.WriteLine(item);
}*/


//Queue<int> - GENERIC
/*Queue<int> queue = new Queue<int>();
queue.Enqueue(32);
queue.Dequeue();
queue.Contains(32); //чи містить?*/


//SortedDictionary - GENERIC (може бути тільки шаблонним)
/*SortedDictionary<int, string> dictionary = new SortedDictionary<int, string>();
dictionary.Add(32, "Ber");
dictionary.Add(323, "Joklin");

foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Value}");
}
*/


//Hashtable - не є шаблонним
/*Hashtable hashtable = new Hashtable();
hashtable.Add(32, "32");
hashtable.Add("ew", 32);*/