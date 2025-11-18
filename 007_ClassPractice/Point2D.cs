namespace Figures2D
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
        public void Print()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
    }
}

