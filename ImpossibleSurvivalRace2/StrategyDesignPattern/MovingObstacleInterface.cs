namespace ImpossibleSurvivalRace2.DesignPattern
{
    public interface MovingObstacleInterface
    {
        void SetStrategy(MovementInterface strategy);
        void ExecuteStrategy();
    }
}
