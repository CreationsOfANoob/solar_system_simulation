using System;

namespace solar_system_simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var TestPlanet = new Planet(0f, 0f);
            Console.WriteLine(TestPlanet.Name);
        }
    }
}
