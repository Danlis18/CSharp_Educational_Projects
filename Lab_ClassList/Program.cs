using Lab_ClassList;
Console.OutputEncoding = System.Text.Encoding.UTF8;

List<SimplePlanet> planets = new List<SimplePlanet>()
{
    new SimplePlanet {
        Name = "Mercury",
        Radious = 2439.7,
        Mass = 3.301e23,
        Volume = 6.083e10,
        PlanetArea = 7.48e7,
        time = TimeSpan.FromHours(1407.6),
        Sattelites = new List<Planet>()
    },

    new SimplePlanet {
        Name = "Venus",
        Radious = 6051.8,
        Mass = 4.867e24,
        Volume = 9.284e11,
        PlanetArea = 4.60e8,
        time = TimeSpan.FromHours(5832.5),
        Sattelites = new List<Planet>()
    },

    new SimplePlanet {
        Name = "Earth",
        Radious = 6371.0,
        Mass = 5.972e24,
        Volume = 1.08321e12,
        PlanetArea = 5.10e8,
        time = TimeSpan.FromHours(24),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Moon",
                Radious = 1737.4,
                Mass = 7.347e22,
                Volume = 2.1958e10,
                PlanetArea = 3.793e7,
                time = TimeSpan.FromHours(655.7),
                SunDistance = 149.6e6
            }
        }
    },

    new SimplePlanet {
        Name = "Mars",
        Radious = 3389.5,
        Mass = 6.417e23,
        Volume = 1.6318e11,
        PlanetArea = 1.44e8,
        time = TimeSpan.FromHours(24.6),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Phobos",
                Radious = 11.27,
                Mass = 1.0659e16,
                Volume = 5.7e3,
                PlanetArea = 1.5e3,
                time = TimeSpan.FromHours(7.66),
                SunDistance = 227.9e6
            },
            new SimplePlanet {
                Name = "Deimos",
                Radious = 6.2,
                Mass = 1.4762e15,
                Volume = 999,
                PlanetArea = 999,
                time = TimeSpan.FromHours(30.3),
                SunDistance = 227.9e6
            }
        }
    },

    new SimplePlanet {
        Name = "Jupiter",
        Radious = 69911,
        Mass = 1.898e27,
        Volume = 1.431e15,
        PlanetArea = 6.14e10,
        time = TimeSpan.FromHours(9.9),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Io",
                Radious = 1821.6,
                Mass = 8.93e22,
                Volume = 2.53e10,
                PlanetArea = 4.19e7,
                time = TimeSpan.FromHours(42.5),
                SunDistance = 778.5e6
            },
            new SimplePlanet {
                Name = "Europa",
                Radious = 1560.8,
                Mass = 4.80e22,
                Volume = 1.6e10,
                PlanetArea = 3.1e7,
                time = TimeSpan.FromHours(85.2),
                SunDistance = 778.5e6
            },
            new SimplePlanet {
                Name = "Ganymede",
                Radious = 2634.1,
                Mass = 1.48e23,
                Volume = 7.6e10,
                PlanetArea = 8.7e7,
                time = TimeSpan.FromHours(171.7),
                SunDistance = 778.5e6
            },
            new SimplePlanet {
                Name = "Callisto",
                Radious = 2410.3,
                Mass = 1.08e23,
                Volume = 5.9e10,
                PlanetArea = 7.3e7,
                time = TimeSpan.FromHours(400.5),
                SunDistance = 778.5e6
            }
        }
    },

    new SimplePlanet {
        Name = "Saturn",
        Radious = 58232,
        Mass = 5.683e26,
        Volume = 8.271e14,
        PlanetArea = 4.27e10,
        time = TimeSpan.FromHours(10.7),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Titan",
                Radious = 2574.7,
                Mass = 1.345e23,
                Volume = 7.2e10,
                PlanetArea = 8.3e7,
                time = TimeSpan.FromHours(382.7),
                SunDistance = 1.433e9
            },
            new SimplePlanet {
                Name = "Enceladus",
                Radious = 252.1,
                Mass = 1.08e20,
                Volume = 6.0e7,
                PlanetArea = 8.0e5,
                time = TimeSpan.FromHours(32.9),
                SunDistance = 1.433e9
            }
        }
    },

    new SimplePlanet {
        Name = "Uranus",
        Radious = 25362,
        Mass = 8.681e25,
        Volume = 6.833e13,
        PlanetArea = 8.10e9,
        time = TimeSpan.FromHours(17.2),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Titania",
                Radious = 788.9,
                Mass = 3.4e21,
                Volume = 2.0e9,
                PlanetArea = 7.8e6,
                time = TimeSpan.FromHours(208.9),
                SunDistance = 2.877e9
            },
            new SimplePlanet {
                Name = "Oberon",
                Radious = 761.4,
                Mass = 3.0e21,
                Volume = 1.8e9,
                PlanetArea = 7.3e6,
                time = TimeSpan.FromHours(323.1),
                SunDistance = 2.877e9
            }
        }
    },

    new SimplePlanet {
        Name = "Neptune",
        Radious = 24622,
        Mass = 1.024e26,
        Volume = 6.254e13,
        PlanetArea = 7.64e9,
        time = TimeSpan.FromHours(16.1),
        Sattelites = new List<Planet>()
        {
            new SimplePlanet {
                Name = "Triton",
                Radious = 1353.4,
                Mass = 2.14e22,
                Volume = 7.5e9,
                PlanetArea = 2.3e7,
                time = TimeSpan.FromHours(141.0),
                SunDistance = 4.503e9
            }
        }
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
Console.WriteLine();
Console.WriteLine();
