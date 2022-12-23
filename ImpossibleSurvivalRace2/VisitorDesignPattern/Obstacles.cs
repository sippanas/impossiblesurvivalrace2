namespace ImpossibleSurvivalRace2.VisitorDesignPattern
{
    public class Obstacles
    {
        public List<Obstacle> obstacles=new List<Obstacle>();

        public void Attach(Obstacle obstacle)
        {
            obstacles.Add(obstacle);
        }

        public void Detach(Obstacle obstacle)
        {
            obstacles.Remove(obstacle);
        }

        public void Accept(IVisitor visitor)
        {
            foreach(Obstacle obj in obstacles)
            {
                obj.AcceptVisitor(visitor);
            }
        }
    }
}
