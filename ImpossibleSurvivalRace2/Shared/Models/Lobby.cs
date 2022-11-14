namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class Lobby
    {
        public Player Creator { get; set; }
        public List<Player>? Players { get; set; }
    }
}
