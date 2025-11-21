namespace _013_014_HomeWork
{
    class Trapeze : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return (a + b) / 2 * Height;
        }

        public override double Perimeter()
        {
            return a + b + Math.Sqrt(Math.Pow((b - a) / 2, 2) + Math.Pow(Height, 2)) * 2;
        }
    }
}
