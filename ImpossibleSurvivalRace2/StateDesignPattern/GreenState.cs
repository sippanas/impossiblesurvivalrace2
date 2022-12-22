using ImpossibleSurvivalRace2.Shared;
using ImpossibleSurvivalRace2.Shared.Models;
using System.Security.Principal;
using System.Xml;

namespace ImpossibleSurvivalRace2.StateDesignPattern
{
    public class GreenState : State
    {
        // Constructor
        public GreenState(State state) :
              this(state.FuelAmt, state.Player)
        {
        }
        public GreenState(int fuelAmt, PlayerState player)
        {
            this.fuelAmt = fuelAmt;
            this.player = player;
            Initialize();
        }
        private void Initialize()
        {
            LowerLimit = (int)(Constants.FUEL_AMOUNT * 0.75);
            Upperlimit = Constants.FUEL_AMOUNT;
        }
        public override void AddFuel(int amount)
        {
            fuelAmt += amount;
            StateChangeCheck();
        }
        public override void SubtractFuel(int amount)
        {
            fuelAmt -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (fuelAmt < LowerLimit)
            {
                player.State = new YellowState(this);
            }
        }
    }
}
