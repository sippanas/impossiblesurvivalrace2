using ImpossibleSurvivalRace2.Shared.Models;
using System.Security.Principal;

namespace ImpossibleSurvivalRace2.StateDesignPattern
{
    public abstract class State
    {
        protected PlayerState player;
        protected int fuelAmt;

        protected int Upperlimit;
        protected int LowerLimit;

        public PlayerState Player
        {
            get { return player; }
            set { player = value; }
        }
        public int FuelAmt
        {
            get { return fuelAmt; }
            set { fuelAmt = value; }
        }
        public abstract void AddFuel(int amount);
        public abstract void SubtractFuel(int amount);

    }
}
