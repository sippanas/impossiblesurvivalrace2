using ImpossibleSurvivalRace2.StateDesignPattern;
using System.Drawing;

namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class Player
    {
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public string Color { get; set; }
        public Player()
        {
            ConnectionId = string.Empty;
            UserName = string.Empty;
            Color = string.Empty;
        }

    }
}
