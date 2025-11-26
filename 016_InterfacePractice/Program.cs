using _016_InterfacePractice;

FigurAbstract[] figurAbstract = new FigurAbstract[] {
    new Circle(new Point(5, 5), 10, ConsoleColor.Red, 3),
    new Rectangle(new Point[] { new Point(0, 0), new Point(0, 4), new Point(6, 4), new Point(6, 0) }, ConsoleColor.Green, 2),
    new Triangle(new Point[] { new Point(0, 0), new Point(2, 3), new Point(4, 0) }, ConsoleColor.Blue, 1),
    new Line(new Point(1, 1), new Point(4, 4), ConsoleColor.Yellow, 1)
};

foreach (var figure in figurAbstract)
{
    figure.Drow();
}
Console.WriteLine();

Console.WriteLine("Line move:");
Line line = new Line(new Point(1, 1), new Point(4, 4), ConsoleColor.Yellow, 1);
line.Right(new Point(10, 0));
line.Drow();
line.Left(new Point(7, 0));
line.Drow();
line.Down(new Point(0, 21));
line.Drow();
line.Up(new Point(0, 32));
line.Drow();

Console.WriteLine();

Console.WriteLine("Triangle move:");
Triangle triangle = new Triangle(new Point[] { new Point(0, 0), new Point(2, 3), new Point(4, 0) }, ConsoleColor.Blue, 1);
triangle.Down(new Point(0, 5));
triangle.Drow();
triangle.Left(new Point(100, 0));
triangle.Drow();
triangle.Right(new Point(200, 0));
triangle.Drow();
triangle.Up(new Point(0, 50));
triangle.Drow();

Console.WriteLine();

Console.WriteLine("Rectangle move:");
Rectangle rectangle = new Rectangle(new Point[] { new Point(0, 0), new Point(0, 4), new Point(6, 4), new Point(6, 0) }, ConsoleColor.Green, 2);
rectangle.Down(new Point(0, 5));
rectangle.Drow();
rectangle.Left(new Point(100, 0));
rectangle.Drow();
rectangle.Right(new Point(200, 0));
rectangle.Drow();
rectangle.Up(new Point(0, 50));
    
rectangle.Drow();

Console.WriteLine();

Console.WriteLine("Circle move:");
Circle circle = new Circle(new Point(5, 5), 10, ConsoleColor.Red, 3);
circle.Down(new Point(0, 5));
circle.Drow();
circle.Left(new Point(100, 0));
circle.Drow();
circle.Right(new Point(200, 0));
circle.Drow();
circle.Up(new Point(0, 50));
circle.Drow();
Console.WriteLine();