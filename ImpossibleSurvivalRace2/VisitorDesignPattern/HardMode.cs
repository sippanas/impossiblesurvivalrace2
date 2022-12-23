using ImpossibleSurvivalRace2.DesignPattern;
using ImpossibleSurvivalRace2.Shared;

namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public class HardMode : IVisitor
    {
        private int Count = Constants.HARD_OBSTACLE_COUNT;
        Coordinate[] canvasCorners= { };
        Coordinate[] innerCorners= { };
        public void VisitStatic(StaticObstacle obj)
        {
            canvasCorners=canvasCorners.Append(new Coordinate(0,0)).ToArray();
            canvasCorners = canvasCorners.Append(new Coordinate(Constants.CANVAS_WIDTH, 0)).ToArray();
            canvasCorners =canvasCorners.Append(new Coordinate(0, Constants.CANVAS_HEIGHT)).ToArray();
            canvasCorners=canvasCorners.Append(new Coordinate(Constants.CANVAS_WIDTH, Constants.CANVAS_HEIGHT)).ToArray();

            innerCorners=innerCorners.Append(new Coordinate(50, 50)).ToArray();
            innerCorners=innerCorners.Append(new Coordinate(Constants.CANVAS_WIDTH - 50, 50)).ToArray();
            innerCorners=innerCorners.Append(new Coordinate(50, Constants.CANVAS_HEIGHT -50)).ToArray();
            innerCorners=innerCorners.Append(new Coordinate(Constants.CANVAS_WIDTH - 50, Constants.CANVAS_HEIGHT - 50)).ToArray();

            double minLat = canvasCorners.Min(x => x.Latitude);
            double minLon = canvasCorners.Min(x => x.Longitude);
            double maxLat = canvasCorners.Max(x => x.Latitude);
            double maxLon = canvasCorners.Max(x => x.Longitude);
            Random r = new Random();

            Coordinate point = new Coordinate(0,0);

            do
            {
                point.Latitude = r.NextDouble() * (maxLat - minLat) + minLat;
                point.Longitude = r.NextDouble() * (maxLon - minLon) + minLon;
            } while (IsPointInPolygon(point, innerCorners));

            obj.X = point.Longitude;
            obj.Y=point.Latitude;

        }
        public void VisitMoving(MovingObstacle obj)
        {

        }

        //only works with correct polygon point sequence
        private bool IsPointInPolygon(Coordinate point, Coordinate[] polygon)
        {
            bool inside = false;

            double startX = polygon[0].Longitude;
            double endX = polygon[1].Longitude;
            double startY = polygon[0].Latitude;
            double endY = polygon[2].Latitude;

            if (point.Longitude > startX && point.Longitude < endX &&
                point.Latitude > startY && point.Latitude < endY)
                inside = true;

            return inside;
        }
    }
}
