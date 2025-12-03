namespace _020_Generics
{
    class Point2D<T>
    {
        private T x;
        private T y;

        public Point2D()
        {
            x = default(T);
            y = default(T);
        }
        public Point2D(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return $"X: {x}, Y: {y}";
        }
    }
}
