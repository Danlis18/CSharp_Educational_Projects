namespace _013_014_HomeWork //не має наслідувати
{
    class ComplexFigure //приймає список фігур
    {
        public double Area(List<Figure> figures)
        {
            double totalArea = 0;
            foreach (var figure in figures)
            {
                totalArea += figure.Area();
            }
            return totalArea;
        }
    }
}
