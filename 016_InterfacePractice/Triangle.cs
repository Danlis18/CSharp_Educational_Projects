namespace _016_InterfacePractice
{
    internal class Triangle : FigurAbstract, IMove
    {
        Point[] points = new Point[3];

        public Triangle(Point[] points, ConsoleColor color, int thickness)
            : base(color, thickness)
        {
            this.points = points;
        }

        public void Down(Point distance)
        {
            throw new NotImplementedException();
        }

        public override void Drow()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Triangle: P1 = {points[0]}, P2 = {points[1]}, P3 = {points[2]}");
            Console.ResetColor();
        }

        public void Left(Point distance)
        {
            throw new NotImplementedException();
        }

        public void Right(Point distance)
        {
            throw new NotImplementedException();
        }

        public void Up(Point distance)
        {
            throw new NotImplementedException();
        }
    }
}
