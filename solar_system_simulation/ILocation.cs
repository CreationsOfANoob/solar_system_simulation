namespace solar_system_simulation
{
    public interface ILocation
    {
        public float distanceBetweenLocations(Coordinate p1, Coordinate p2);
    }

    public class Coordinate
    {
        public float X;
        public float Y;
        public float Z;

        public Coordinate(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }
    }
}