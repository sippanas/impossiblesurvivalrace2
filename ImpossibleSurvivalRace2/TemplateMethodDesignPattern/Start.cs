using Blazor.Extensions.Canvas.Canvas2D;
using ImpossibleSurvivalRace2.Server;
using ImpossibleSurvivalRace2.Shared.Models;
using Microsoft.AspNetCore.SignalR.Client;
using ImpossibleSurvivalRace2.Pages;

namespace ImpossibleSurvivalRace2.TemplateMethodDesignPattern
{
    public class Start : StartAbstract
    {
        public bool HasStarted { get; set; }
        public Start()
        {
            this.HasStarted = false;
        }
        public Start(bool hasStarted)
        {
            this.HasStarted = hasStarted;
        }

        public override void TemplateMethod()
        {
            throw new NotImplementedException();
        }

        public override void DrawMap()
        {
            throw new NotImplementedException();
        }

        public override async Task SpawnPlayer(Player player, Canvas2DContext context, int x, int y, bool isLocalPlayer)
        {
            Pages.Lobby lobby = new();
            await lobby.DrawPlayer(player, context, x, y, isLocalPlayer);
        }
    }
}
