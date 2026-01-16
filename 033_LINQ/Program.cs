// LINQ - мова запитів до певних колекцій даних у C#.

// LINQ to Objects
// LINQ to XML
// LINQ to Entities
// LINQ to SQL
// Parallel LINQ

//IEnumerable
int[] arrayInt = { 132, 22, 34, -65, 435, 76, -7, -8, 879, 71};

//Синтаксис запитів
//from, in, where, select

//select
//IEnumerable<int> query = from number in arrayInt select number; //проходимося по вссій колеційї і вибираємо усі елементи

// where
/*bool isSimple(int a)
{
    for (int i = 2; i < a; i++)
    {
        if (a % i == 0)
            return false;
    }
    return true;
}

IEnumerable<int> query = from i in arrayInt
                         where isSimple(i)
                         select i;

foreach (int item in query)
{
    Console.Write($"{item} ");
}*/

//orderby
/*var query = from i in arrayInt
            orderby i descending
            select i;


foreach (int item in query)
{
    Console.Write($"{item} ");
}

var query = from i in arrayInt
            where i % 2 == 0
            orderby i descending
            select i;


foreach (int item in query)
{
    Console.Write($"{item} ");
}*/

//Синтаксис методів
arrayInt.Select(i => i); //select
arrayInt.Where(i => i % 2 == 0); //where
arrayInt.OrderByDescending(i => i); //orderby