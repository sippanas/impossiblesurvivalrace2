namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public class MovingObstacle : Obstacle
    {
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitMoving(this);
        }
    }
}
