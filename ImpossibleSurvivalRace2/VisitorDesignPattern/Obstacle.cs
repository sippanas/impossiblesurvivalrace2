namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public abstract class Obstacle
    {
        public double X = 0;
        public double Y = 0;
        public int RemovesFuelQuantity { get; set; }

        public abstract void AcceptVisitor(IVisitor visitor);
    }
}
