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

        public void Up(Point distance)
        {
            throw new NotImplementedException();
        }

        public void Down(Point distance)
        {
            throw new NotImplementedException();
        }

        public void Left(Point distance)
        {
            throw new NotImplementedException();
        }

        public void Right(Point distance)
        {
            throw new NotImplementedException();
        }
    }
}
