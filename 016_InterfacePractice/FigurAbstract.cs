using System.Drawing;

namespace _016_InterfacePractice
{
    abstract class FigurAbstract
    {
        public ConsoleColor color { get; set; }
        public int thickness { get; set; }

        protected FigurAbstract(ConsoleColor color, int thickness)
        {
            this.color = color;
            this.thickness = thickness;
        }

        public abstract void Drow();

        public abstract void Up(Point distance);
        public abstract void Down(Point distance);
        public abstract void Left(Point distance);
        public abstract void Right(Point distance);
    }
}
