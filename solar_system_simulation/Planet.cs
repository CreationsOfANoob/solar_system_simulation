using System;
namespace solar_system_simulation
{
    public class Planet : ILocation
    {
        public string Name { get; }

        public Planet(string name)
        {
            Name = name;
        }

        public float distanceBetweenLocations(Coordinate p1, Coordinate p2)
        {
            throw new NotImplementedException();
        }
    }
}
