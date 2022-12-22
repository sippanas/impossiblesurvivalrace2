using ImpossibleSurvivalRace2.Shared;
using System.Security.Principal;

namespace ImpossibleSurvivalRace2.StateDesignPattern
{
    public class RedState:State
    {
        public RedState(State state)
        {
            this.fuelAmt = state.FuelAmt;
            this.player = state.Player;
            Initialize();
        }
        private void Initialize()
        {
            LowerLimit = 0;
            Upperlimit = (int)(Constants.FUEL_AMOUNT * 0.25);
        }
        public override void AddFuel(int amount)
        {
            fuelAmt += amount;
            StateChangeCheck();
        }
        public override void SubtractFuel(int amount)
        {
            fuelAmt-= amount;
            StateChangeCheck();
        }
        
        private void StateChangeCheck()
        {
            if (fuelAmt > Upperlimit)
            {
                player.State = new YellowState(this);
            } else if(fuelAmt < LowerLimit)
            {
                player.State = new DeadState(this);
            }
        }
    }
}
