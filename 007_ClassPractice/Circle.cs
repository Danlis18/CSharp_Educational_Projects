

using Figures2D;

namespace _007_ClassPractice
{
    internal class Circle
    {
        private Point sirclePoint;
        private int radius;

        public Circle(Point sirclePoint, int radius)
        {
            this.radius = radius;
            this.sirclePoint = sirclePoint;
        }
        public double GetArea(int radius) {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double GetFerence(int radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public bool isPointInCircle(Point pointCheck)
        {
            bool isInside = (Math.Pow(pointCheck.GetX() - sirclePoint.GetX(), 2) + Math.Pow(pointCheck.GetY() - sirclePoint.GetY(), 2)) <= Math.Pow(this.radius, 2);
            return isInside;
        }
    }
}
