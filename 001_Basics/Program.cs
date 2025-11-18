/* Console.Write("Hello C#");
Console.WriteLine("Next Line");
Console.WriteLine("aaa"); */


// 4байт - 32біти


// +, -, *, /, %

//Console.Write("Enter number1: ");
//int a = Convert.ToInt32(Console.ReadLine());  // 20
//Console.Write("Enter number2: ");
//int b = Convert.ToInt32(Console.ReadLine());  // 30

//int sum = a + b;

// int a = 5, b = 10;

// a = 5, b = 10

//Console.WriteLine("a = " + a + ", b = " + b);
//Console.WriteLine(string.Format("a = {0}, b = {1}", a, b));
//Console.WriteLine($"a = {a}, b = {b}, sum = {sum}");


// Типи значень, структурні(value types) - базуються на структурах
// і пов'язані із копіюванням значень
// Типи посилань(reference types) - базуються на класах
// і пов'язані із копіюванням посилань

// int, float, double, char, bool

//int a = 5;
//int b = a;


//using _001_Basics;

//Point p1 = new Point();

//p1.X = 10;
//p1.Y = 20;

//Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");


////Point p2 = p1;

////p2.X = 1000;

////Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");

//Point p2 = new Point();

//p2.X = p1.X;
//p2.Y = p1.Y;

//p2.X = 1000;

//Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");


// Тернарний оператор

//int a = 5, b = 7;

//int max = a > b ? a : b;

//Console.WriteLine($"Max: {max}");


//int a = 10;

//if(a > 5)
//{
//    Console.WriteLine("Hello");
//}
//else if(a < 10)
//{
//    Console.WriteLine("Goodbye");
//}


// 4
// +
// 5
// 9

//Console.Write("Enter sign: ");
//string choice = Console.ReadLine();
//Console.Write("Enter №n1: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter №2: ");
//int b = Convert.ToInt32(Console.ReadLine());


//int res = 0 ;

//switch (choice)
//{
//    case "+":
//        res = a + b;

//        break;
//    case "-":
//        res = a - b;
//        break;
//    case "*":
//        res = a * b;
//        break;
//    case "/":
//        res = a / b;
//        break;
//    default:
//        Console.WriteLine("Smt happened");
//        break;
//}


//Console.WriteLine($"Res = {res}");


// while, do while, for


//int i = 0;

//while(i < 100)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int[] arr = { 1, 5, -2, 5, 100 };

//foreach(int el in arr)
//{
//    Console.Write($"{el} ");
//}
