namespace _016_InterfacePractice
{
    class Circle : FigurAbstract, IMove
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

        public override void Down(Point distance)
        {
            for (int i = 0; i < 1; i++)
            {
                center = new Point(center.X, center.Y + distance.Y);
            }
        }

        public override void Left(Point distance)
        {
            for (int i = 0; i < 1; i++)
            {
                center = new Point(center.X - distance.X, center.Y);
            }
        }

        public override void Right(Point distance)
        {
            for (int i = 0; i < 1; i++)
            {
                center = new Point(center.X + distance.X, center.Y);
            }
        }

        public override void Up(Point distance)
        {
            for (int i = 0; i < 1; i++)
            {
                center = new Point(center.X, center.Y - distance.Y);
            }
        }
    }
}
