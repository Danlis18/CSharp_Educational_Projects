namespace _008_Prpperties
{
    class Rectangle
    {
        double widht;
        double height;

        public double Widht
        {
            get
            {
                return widht;
            }
            set
            {
                if (value >= 0.0000001)
                {
                    widht = value;
                }
                else
                {
                    Console.WriteLine("Value can not be unsighed");
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value >= 0.0000001)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Value can not be unsighed");
                }

            }
        }

        public double Area
        {
            get
            {
                return widht * height;
            }
        }

        public double Perimetr
        {
            get
            {
                return (widht + height) * 2;
            }
        }
    }
}
