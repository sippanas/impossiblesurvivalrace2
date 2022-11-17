namespace ImpossibleSurvivalRace2.Shared.Models
{
    /// <summary>
    /// Abstract product class
    /// </summary>
    public abstract class Vehicle { }

    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Car : Vehicle { }

    /// <summary>
    /// Concrete product class
    /// </summary>
    public class Tank : Vehicle { }

    /// <summary>
    /// Creator abstract class
    /// </summary>
    public abstract class Garage
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();

        public Garage()
        {
            this.Build();
        }

        public List<Vehicle> Vehicles
        {
            get { return _vehicles; }
        }

        public abstract Vehicle Build(); // Factory method
    }

    /// <summary>
    /// Concrete creator class
    /// </summary>
    public class CarGarage : Garage
    {
        public override Vehicle Build()
        {
            return new Car();
        }
    }

    /// <summary>
    /// Concrete creator class
    /// </summary>
    public class TankGarage : Garage
    {
        public override Vehicle Build()
        {
            return new Tank();
        }
    }
}
