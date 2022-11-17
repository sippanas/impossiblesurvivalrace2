namespace ImpossibleSurvivalRace2.DesignPattern
{
    public class MovementContext: MovementContextInterface
    {
        private MovementInterface _strategy;

        public MovementContext()
        { }

        public MovementContext(MovementInterface strategy)
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
