using System.Xml.Linq;

namespace Lab_ClassList
{
    class SolarSystem
    {
        List<SimplePlanet> planets;

        public SolarSystem (List<SimplePlanet> planets)
        {
            this.planets = planets;
        }

        public SimplePlanet SearchPlanet(string name)
        {
            return planets.Find(x => x.Name == name);
        }

        public SimplePlanet SearchMaxMass()
        {
            return planets.Find(x => x.Mass == );
        }

        public void print()
        {
            foreach (SimplePlanet planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
