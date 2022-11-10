namespace ImpossibleSurvivalRace2.Models
{
    public abstract class ObstacleFactory
    {
        public int  RemovesQuantity { get; set; }
        public abstract void Spawn();

    }
}
