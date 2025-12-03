namespace _020_Generics
{
    internal class Point3D<T> : Point2D<T> 
    {
        private T z;

        public Point3D(T x, T y, T z) : base(x, y)
        {
            this.z = z;
        }
        public T Z
        {
            get { return z; }
            set { z = value; }
        }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}
