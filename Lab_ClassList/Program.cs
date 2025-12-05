using Lab_ClassList;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<SimplePlanet> planets = new List<SimplePlanet>()
{
    new SimplePlanet {
        Name = "Mercury",
        Radious = 2439.7, // km
        Mass = 3.301e23,  // kg
        Volume = 6.083e10, // km³
        PlanetArea = 7.48e7, // km²
        time = TimeSpan.FromHours(1407.6) // тривалість доби
    },
    new SimplePlanet {
        Name = "Venus",
        Radious = 6051.8,
        Mass = 4.867e24,
        Volume = 9.284e11,
        PlanetArea = 4.60e8,
        time = TimeSpan.FromHours(5832.5)
    },
    new SimplePlanet {
        Name = "Earth",
        Radious = 6371.0,
        Mass = 5.972e24,
        Volume = 1.08321e12,
        PlanetArea = 5.10e8,
        time = TimeSpan.FromHours(24)
    },
    new SimplePlanet {
        Name = "Mars",
        Radious = 3389.5,
        Mass = 6.417e23,
        Volume = 1.6318e11,
        PlanetArea = 1.44e8,
        time = TimeSpan.FromHours(24.6)
    },
    new SimplePlanet {
        Name = "Jupiter",
        Radious = 69911,
        Mass = 1.898e27,
        Volume = 1.431e15,
        PlanetArea = 6.14e10,
        time = TimeSpan.FromHours(9.9)
    },
    new SimplePlanet {
        Name = "Saturn",
        Radious = 58232,
        Mass = 5.683e26,
        Volume = 8.271e14,
        PlanetArea = 4.27e10,
        time = TimeSpan.FromHours(10.7)
    },
    new SimplePlanet {
        Name = "Uranus",
        Radious = 25362,
        Mass = 8.681e25,
        Volume = 6.833e13,
        PlanetArea = 8.10e9,
        time = TimeSpan.FromHours(17.2)
    },
    new SimplePlanet {
        Name = "Neptune",
        Radious = 24622,
        Mass = 1.024e26,
        Volume = 6.254e13,
        PlanetArea = 7.64e9,
        time = TimeSpan.FromHours(16.1)
    }
};



SolarSystem solarSystem = new SolarSystem(planets);

solarSystem.print();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(solarSystem.SearchPlanet("Venus"));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(solarSystem.SearchMaxMass());
