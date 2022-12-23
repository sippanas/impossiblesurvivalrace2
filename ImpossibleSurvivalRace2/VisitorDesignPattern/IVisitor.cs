using ImpossibleSurvivalRace2.DesignPattern;
using System.Xml.Linq;

namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public interface IVisitor
    {
        public void VisitStatic(StaticObstacle obj);
        public void VisitMoving(MovingObstacle obj);

    }
}
