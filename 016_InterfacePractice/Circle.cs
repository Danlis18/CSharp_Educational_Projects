namespace _016_InterfacePractice
{
    internal class Circle : FigurAbstract, IMove
    {
        Point center;
        double radius;

        public Circle(Point center, double radius, ConsoleColor color, int thickness)
            : base(color, thickness)
        {
            this.center = center;
            this.radius = radius;
        }

        public override void Drow()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Circle: Center = {center}, Radius = {radius}");
            Console.ResetColor();
        }

        public void Down(Point distance)
        {
            Console.WriteLine($"Circle moved down by {distance} units");
        }

        public void Left(Point distance)
        {
            Console.WriteLine($"Circle moved left by {distance} units");
        }

        public void Right(Point distance)
        {
            Console.WriteLine($"Circle moved right by {distance} units");
        }

        public void Up(Point distance)
        {
            Console.WriteLine($"Circle moved up by {distance} units");
        }
    }
}
