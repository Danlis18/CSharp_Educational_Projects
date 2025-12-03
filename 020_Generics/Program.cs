using _020_Generics;
using System.Collections;

/*MyGenericClass<int> myClass = new MyGenericClass<int>(100);
Console.WriteLine(myClass);

MyGenericClass<string> myStringClass = new MyGenericClass<string>("Hello Generics");
Console.WriteLine(myStringClass);

MyGenericClass<double> myDoubleClass = new MyGenericClass<double>();
Console.WriteLine(myDoubleClass);*/

//object
/*List<int> list1 = new List<int>();
List<string> list2 = new List<string>();


ArrayList arrayList = new ArrayList();
arrayList.Add("DIKOL");
arrayList.Add(1234);*/


//bocxing unboxing
/*object obj = 42; // Boxing
int unboxedValue = (int)obj; // Unboxing
Console.WriteLine($"Unboxed Value: {unboxedValue}");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int a = list1[0]; // No boxing occurs here
Console.WriteLine($"First Element from list1: {a}");*/

Point2D<double> point2DDouble = new Point2D<double>(3.5, 7.2);
Console.WriteLine(point2DDouble);
Point3D<int> point3DInt = new Point3D<int>(5, 43, 45);
Console.WriteLine(point3DInt);

Point3D<string> point3DString = new Point3D<string>("X_Value", "Y_Value", "Z_Value");
Console.WriteLine(point3DString);