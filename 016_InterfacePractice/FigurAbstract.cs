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
    }
}
