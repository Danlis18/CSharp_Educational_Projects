namespace _011_OperatorsOverloading
{
    class MyArray
    {
        public int [] Arr { get; set; }

        public MyArray()
        {
           
        }
        public MyArray(int[] Arr)
        {
            this.Arr = Arr;
        }

        public int Length
        {
            get
            {
                return this.Arr.Length;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Arr: {string.Join(", ", Arr)}");
        }

        //Перевантаження індексатора квадратних дужок:
        public int this[int index]
        {
            get { return Arr[index]; }
            set
            {
                if (index >= 0 && index < Arr.Length)
                    Arr[index] = value;
            }
        }
    }
}
