namespace _016_InterfacePractice
{
    internal class Rectangle : FigurAbstract, IMove
    {
        Point[] points;

        public Rectangle(Point[] points, ConsoleColor color, int thickness)
            : base(color, thickness)
        { 
            this.points = points;
        }

        public override void Drow()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Rectangle: P1 = {points[0]}, P2 = {points[1]}, P3 = {points[2]}, P4 = {points[3]}");
            Console.ResetColor();
        }
        public override void Down(Point distance)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(points[i].X, points[i].Y - distance.Y);
            }
        }
        public override void Left(Point distance)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(points[i].X - distance.X, points[i].Y);
            }
        }

        public override void Right(Point distance)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(points[i].X + distance.X, points[i].Y);
            }
        }

        public override void Up(Point distance)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(points[i].X, points[i].Y + distance.Y);
            }
        }
    }
}
