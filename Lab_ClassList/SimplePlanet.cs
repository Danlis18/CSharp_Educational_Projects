using System.Runtime.InteropServices;

namespace Lab_ClassList
{
    internal class SimplePlanet : Planet
    {
       public List<Planet> Sattelites { get; set; } = new List<Planet>();

        public override string ToString()
        {
            string result = $"Name: {Name}\n" +
                   $"Radious: {Radious} km\n" +
                   $"Mass: {Mass} kg\n" +
                   $"Volume: {Volume} km³\n" +
                   $"Planet Area: {PlanetArea} km²\n" +
                   $"Rotation Period: {time}\n";

            if (Sattelites.Count > 0)
            {
                result += "Satellites:\n";

                foreach (var s in Sattelites)
                {
                    result += "  -------------------\n";
                    result += "  " + s.ToString();
                    result += $"Sun distance: {s.SunDistance} km\n";
                }
            }
            else
            {
                result += "Satellites: none\n";
            }

            return result;
        }
    }
}
