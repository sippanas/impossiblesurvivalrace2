using ImpossibleSurvivalRace2.StateDesignPattern;
using System.Drawing;

namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class PlayerState
    {
        public string ConnectionId { get; set; }
        public int _FuelAmt { get; set; }

        private State state;

        public PlayerState(string connection)
        {
            ConnectionId = connection;
            this.state = new GreenState(0, this);
        }
        public int FuelAmt
        {
            get { return state.FuelAmt; }
        }
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        public void AddFuel(int amount)
        {
            state.AddFuel(amount);
        }
        public void SubtractFuel(int amount)
        {
            state.SubtractFuel(amount);
        }
    }
}
