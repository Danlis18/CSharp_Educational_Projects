namespace _013_014_HomeWork
{
    class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
    }
}
