using _016_InterfacePractice;

FigurAbstract circle = new Circle(new Point(5, 5), 10, ConsoleColor.Red, 3);
circle.Drow();
FigurAbstract rectangle = new Rectangle(new Point[] { new Point(0, 0), new Point(0, 4), new Point(6, 4), new Point(6, 0) }, ConsoleColor.Green, 2);
rectangle.Drow();
FigurAbstract triangle = new Triangle(new Point[] { new Point(0, 0), new Point(2, 3), new Point(4, 0) }, ConsoleColor.Blue, 1);
triangle.Drow();
FigurAbstract line = new Line(new Point(1, 1), new Point(4, 4), ConsoleColor.Yellow, 1);
line.Drow();