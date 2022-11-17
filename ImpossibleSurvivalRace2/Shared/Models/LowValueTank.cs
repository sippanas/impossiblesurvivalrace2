namespace ImpossibleSurvivalRace2.Shared.Models
{
    public class LowValueTank: Fuel
    {
        public double Value { get; set; }

        public LowValueTank(double value) {
            Value = value;
        }

        public override Fuel Clone()
        {
            Console.WriteLine("Cloning a low value fuel tank, value {0}",Value);
            return this.MemberwiseClone() as Fuel;
        }
    }
}
