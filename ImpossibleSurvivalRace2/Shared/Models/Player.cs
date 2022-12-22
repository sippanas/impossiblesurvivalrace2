using ImpossibleSurvivalRace2.StateDesignPattern;
using System.Drawing;

namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class Player
    {
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public string Color { get; set; }
        public int OldX { get; set; }
        public int OldY { get; set; }
        public int OldServerX { get; set; }
        public int OldServerY { get; set; }
    }
}
