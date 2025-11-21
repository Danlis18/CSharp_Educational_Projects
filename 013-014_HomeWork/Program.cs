using _013_014_HomeWork;


// --- КВАДРАТ ---
Square s = new Square();
s.a = 5;
Console.WriteLine("Квадрат:");
Console.WriteLine("Площа: " + s.Area());
Console.WriteLine("Периметр: " + s.Perimeter());

Console.WriteLine();

// --- ТРИКУТНИК ---
Triangle t = new Triangle();
t.a = 3;
t.b = 4;
t.c = 5;
Console.WriteLine("Трикутник:");
Console.WriteLine("Площа: " + t.Area());
Console.WriteLine("Периметр: " + t.Perimeter());

Console.WriteLine();

// --- РОМБ ---
Diamond d = new Diamond();
d.a = 6;
d.Height = 4;
Console.WriteLine("Ромб:");
Console.WriteLine("Площа: " + d.Area());
Console.WriteLine("Периметр: " + d.Perimeter());

Console.WriteLine();

// --- ТРАПЕЦІЯ ---
Trapeze trap = new Trapeze();
trap.a = 6;
trap.Height = 4;
Console.WriteLine("Ромб:");
Console.WriteLine("Площа: " + trap.Area());
Console.WriteLine("Периметр: " + trap.Perimeter());

Console.WriteLine();

//ComplexFigure
List<Figure> figures = new List<Figure>() {trap, d, t, s};
ComplexFigure cf = new ComplexFigure();
Console.WriteLine("Загальна площа: " + cf.Area(figures));


