namespace ImpossibleSurvivalRace2.Models
{
    public class Dot
    {
        public Dot(double strx, double stry, double rad, double strAngle, double enAngle, string col)
        {
            startX = strx;
            startY = stry;
            radius = rad;
            startAngle = strAngle;
            endAngle = enAngle;
            color = col;

        }
        public double startX { get; set; }
        public double startY { get; set; }
        public double radius { get; set; }
        public double startAngle { get; set; }
        public double endAngle { get; set; }
        public string color { get; set; }
    }
}
