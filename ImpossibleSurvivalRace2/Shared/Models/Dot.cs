using System.Numerics;

namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class Dot
    {
        public double startX { get; set; }
        public double startY { get; set; }
        public double radius { get; set; }
        public double startAngle { get; set; }
        public double endAngle { get; set; }
        public string color { get; set; }

        public Dot(double strx, double stry, double rad, double strAngle, double enAngle, string col)
        {
            startX = strx;
            startY = stry;
            radius = rad;
            startAngle = strAngle;
            endAngle = enAngle;
            color = col;
        }

        public Dot(double x, double y, double size, string playerColor)
        {
            startX = x;
            startY = y;
            radius = size;
            startAngle = 0;
            endAngle = Math.PI * 2;
            color = playerColor;
        }
    }
}
