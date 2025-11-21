namespace _013_014_HomeWork
{
    class Square : Figure
    {
        public double a { get; set; }

        public override double Area()
        {
            return a * a;
        }

        public override double Perimeter()
        {
            return 4 * a;
        }
    }
}
