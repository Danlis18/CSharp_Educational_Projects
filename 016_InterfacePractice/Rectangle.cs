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

        public void Down(Point distance)
        {
            throw new NotImplementedException();
        }

        public override void Drow()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Rectangle: P1 = {points[0]}, P2 = {points[1]}, P3 = {points[2]}, P4 = {points[3]}");
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
