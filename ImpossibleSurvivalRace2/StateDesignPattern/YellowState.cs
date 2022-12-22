using ImpossibleSurvivalRace2.Shared;
using ImpossibleSurvivalRace2.Shared.Models;
using System.Reflection.Metadata;
using System.Xml;

namespace ImpossibleSurvivalRace2.StateDesignPattern
{
    public class YellowState : State
    {
        public YellowState(State state) :
               this(state.FuelAmt, state.Player)
        {
        }
        public YellowState(int fuelAmt, PlayerState player)
        {
            this.fuelAmt = fuelAmt;
            this.player = player;
            Initialize();
        }
        private void Initialize()
        {
            LowerLimit = (int)(Constants.FUEL_AMOUNT * 0.25);
            Upperlimit = (int)(Constants.FUEL_AMOUNT * 0.75);
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
            if (fuelAmt > Upperlimit)
            {
                player.State = new GreenState(this);
            }
            else if (fuelAmt < LowerLimit)
            {
                player.State = new RedState(this);
            }
        }
    }
}
