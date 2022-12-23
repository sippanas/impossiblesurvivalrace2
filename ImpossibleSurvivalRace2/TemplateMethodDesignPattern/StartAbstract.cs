using Blazor.Extensions.Canvas.Canvas2D;
using ImpossibleSurvivalRace2.Shared.Models;

namespace ImpossibleSurvivalRace2.TemplateMethodDesignPattern
{
    public abstract class StartAbstract
    {

        public abstract void TemplateMethod();
        public abstract void DrawMap();
        public abstract Task SpawnPlayer(Player player, Canvas2DContext context, int x, int y, bool isLocalPlayer);
    }
}
