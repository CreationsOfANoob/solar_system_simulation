using System;
namespace solar_system_simulation
{
    public class Planet : ILocation
    {
        public string Name { get; }
        public float Radius { get; }
        public float SurfaceGravity { get; }
        public PhysicalObject physicalObject { get; }

        public Planet(float r, float m, string name = "Unnamed Planet")
        {
            physicalObject = new PhysicalObject(m);
            Name = name;
            Radius = r;
        }

        public float distanceBetweenLocations(Coordinate p1, Coordinate p2)
        {
            throw new NotImplementedException();
        }
    }
}
