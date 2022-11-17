namespace ImpossibleSurvivalRace2.DesignPattern
{
    public interface MovementContextInterface
    {
        void SetStrategy(MovementInterface strategy);
        void ExecuteStrategy();
    }
}
