namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class HighValueTank:Fuel
    {
        public double Value { get; set; }

        public HighValueTank(double value)
        {
            Value = value;
        }

        public override Fuel Clone()
        {
            Console.WriteLine("Cloning a high value fuel tank, value {0}",Value);
            return this.MemberwiseClone() as Fuel;
        }
    }
}
