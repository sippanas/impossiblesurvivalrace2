namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public class Coordinate
    {
        public Coordinate(int v1, int v2)
        {
            Longitude = v1;
            Latitude = v2;
        }

        public double Latitude { set; get; }
        public double Longitude { set; get; }
    }
}
