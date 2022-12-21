using ImpossibleSurvivalRace2.DesignPattern;

namespace ImpossibleSurvivalRace2.ProxyDesignPattern
{
    public class MovementProxy: MovementInterface
    {
        private RealMovement movement = new RealMovement();

        public int Up(int top)
        {
            return movement.Up(top);
        }

        public int Down(int top)
        {
            int dump = movement.Down(top);

            return movement.Down(top);
        }

        public int Left(int left)
        {
            return movement.Left(left);
        }

        public int Right(int right)
        {
            return movement.Right(right);
        }
    }
}
