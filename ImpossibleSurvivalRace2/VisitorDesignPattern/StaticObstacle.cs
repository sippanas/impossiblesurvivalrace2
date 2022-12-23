namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public class StaticObstacle : Obstacle
    {
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitStatic(this);
        }

    }
}
