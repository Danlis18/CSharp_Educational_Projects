namespace Lab_ClassList
{
    internal class SimplePlanet : Planet
    {
        public double SunDistance { get; set; }

        List<Planet> sattelites;

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                   $"Radious: {Radious} km\n" +
                   $"Mass: {Mass} kg\n" +
                   $"Volume: {Volume} km³\n" +
                   $"Planet Area: {PlanetArea} km²\n" +
                   $"Rotation Period: {time}\n";
        }
    }


}
