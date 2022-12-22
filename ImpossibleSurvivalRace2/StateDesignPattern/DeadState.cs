namespace ImpossibleSurvivalRace2.StateDesignPattern
{
    public class DeadState :State
    {
        public DeadState(State state)
        {
            this.fuelAmt = state.FuelAmt;
            this.player = state.Player;
            Initialize();
        }
        private void Initialize()
        {
            LowerLimit = 0;
            Upperlimit = 0;
        }
        public override void AddFuel(int amount)
        {
            fuelAmt += amount;
            Console.WriteLine("u dead");
        }
        public override void SubtractFuel(int amount)
        {
            fuelAmt -= amount;
            Console.WriteLine("u dead");

        }

    }
}
