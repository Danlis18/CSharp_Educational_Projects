namespace _016_InterfacePractice
{
    internal class Line : FigurAbstract, IMove
    {
        Point start;
        Point end;

        public Line(Point start, Point end, ConsoleColor color, int thickness)
            : base(color, thickness)
        {
            this.start = start;
            this.end = end;
        }

        public override void Drow()
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"Line: Start = {start}, End = {end}");
            Console.ResetColor();
        }

        public override void Up(Point distance)
        {
            start = new Point(start.X, start.Y - distance.Y);
            end = new Point(end.X, end.Y - distance.Y);
        }

        public override void Down(Point distance)
        {
            start = new Point(start.X, start.Y + distance.Y);
            end = new Point(end.X, end.Y + distance.Y);
        }

        public override void Left(Point distance)
        {
            start = new Point(start.X - distance.X, start.Y);
            end = new Point(end.X - distance.X, end.Y);
        }

        public override void Right(Point distance)
        {
            start = new Point(start.X + distance.X, start.Y);
            end = new Point(end.X + distance.X, end.Y);
        }
    }
}
