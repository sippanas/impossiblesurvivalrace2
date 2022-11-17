namespace ImpossibleSurvivalRace2.DesignPattern
{
    public class MovingObstacle: MovingObstacleInterface
    {
        private MovementInterface _strategy;

        public MovingObstacle()
        { }

        public MovingObstacle(MovementInterface strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(MovementInterface strategy)
        {
            this._strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            this._strategy.CalculateMovement();
        }
    }
}
