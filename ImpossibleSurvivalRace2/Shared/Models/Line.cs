namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class Line
    {
        public Line(double strx, double stry, double enx, double eny, float thick, string col)
        {
            startX = strx;
            startY = stry;
            endX = enx;
            endY = eny;
            thickness = thick;
            color = col;

        }
        public double startX { get; set; }
        public double startY { get; set; }
        public double endX { get; set; }
        public double endY { get; set; }
        public float thickness { get; set; }
        public string color { get; set; }
    }
}
