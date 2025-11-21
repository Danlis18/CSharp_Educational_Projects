namespace _011_OperatorsOverloading

{
    class MyClass
    {
        public int X { get; set; }

        public void Print()
        {
            Console.WriteLine($"X: {X}");
        }

        public static MyClass operator+(MyClass obj1, MyClass obj2) //бинарний оператор +;
        {
            return new MyClass { X = obj1.X + obj2.X };
        }
        public static MyClass operator -(MyClass obj1, MyClass obj2) //бинарний оператор +;
        {
            return new MyClass { X = obj1.X - obj2.X };
        }
    }
}
