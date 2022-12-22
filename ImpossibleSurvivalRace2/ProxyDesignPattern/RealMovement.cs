using ImpossibleSurvivalRace2.DesignPattern;
using ImpossibleSurvivalRace2.StateDesignPattern;

namespace ImpossibleSurvivalRace2.ProxyDesignPattern
{
    public class RealMovement: MovementInterface
    {
        public int Up(int top,State state) {
            switch(state.GetType().Name)
            {
                case "GreenState":
                    return top - 3;
                case "YellowState":
                    return top - 2;
                case "RedState":
                    return top - 1;
                default:
                    return top;
            }     
        }
        public int Down(int top, State state) {
            switch (state.GetType().Name)
            {
                case "GreenState":
                    return top + 3;
                case "YellowState":
                    return top + 2;
                case "RedState":
                    return top + 1;
                default:
                    return top;
            }
        }
        public int Left(int left, State state) {
            switch (state.GetType().Name)
            {
                case "GreenState":
                    return left - 3;
                case "YellowState":
                    return left - 2;
                case "RedState":
                    return left - 1;
                default:
                    return left;
            }
        }
        public int Right(int left, State state) {
            switch (state.GetType().Name)
            {
                case "GreenState":
                    return left + 3;
                case "YellowState":
                    return left + 2;
                case "RedState":
                    return left + 1;
                default:
                    return left;
            }
        }
    }
}
