namespace ImpossibleSurvivalRace2.Shared.Models
{
    public abstract class Fuel
    {
        public int Quantity { get; set; }

        public abstract Fuel Clone();
    }
}
