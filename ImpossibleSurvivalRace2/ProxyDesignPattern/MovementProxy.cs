using ImpossibleSurvivalRace2.DesignPattern;
using ImpossibleSurvivalRace2.StateDesignPattern;

namespace ImpossibleSurvivalRace2.ProxyDesignPattern
{
    public class MovementProxy: MovementInterface
    {
        private RealMovement movement = new RealMovement();

        public int Up(int top, State state)
        {
            return movement.Up(top,state);
        }

        public int Down(int top, State state)
        {
            return movement.Down(top,state);
        }

        public int Left(int left, State state)
        {
            return movement.Left(left,state);
        }

        public int Right(int right, State state)
        {
            return movement.Right(right,state);
        }
    }
}
