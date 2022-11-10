namespace ImpossibleSurvivalRace2.Models
{
    public class Dot
    {
        public Dot(int strx, int stry, int enx, int eny, int thick, string col)
        {
            startX = strx;
            startY = stry;
            endX = enx;
            endY = eny;
            thickness = thick;
            color = col;

        }
        public int startX { get; set; }
        public int startY { get; set; }
        public int endX { get; set; }
        public int endY { get; set; }
        public int thickness { get; set; }
        public string color { get; set; }
    }
}
