using ImpossibleSurvivalRace2.StateDesignPattern;

namespace ImpossibleSurvivalRace2.ProxyDesignPattern
{
    public interface MovementInterface
    {

        public int Up(int top,State state);
        public int Down(int top, State state);
        public int Left(int left, State state);
        public int Right(int left, State state);
    }
}
