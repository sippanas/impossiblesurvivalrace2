using ImpossibleSurvivalRace2.DesignPattern;

namespace ImpossibleSurvivalRace2.ProxyDesignPattern
{
    public class RealMovement: MovementInterface
    {
        public int Up(int top) { return top -= 1; }
        public int Down(int top) { return top += 1; }
        public int Left(int left) { return left -= 1; }
        public int Right(int left) { return left += 1; }
    }
}
