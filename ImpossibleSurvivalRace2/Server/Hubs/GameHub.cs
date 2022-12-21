using ImpossibleSurvivalRace2.Services;
using ImpossibleSurvivalRace2.Shared.Models;
using Microsoft.AspNetCore.SignalR;

namespace ImpossibleSurvivalRace2.Server.Hubs
{
    public class GameHub : Hub<IGameHub>
    {
        private readonly LobbyService _lobbyService = LobbyService.getInstance();

        public GameHub() { }

        public override async Task<Task> OnDisconnectedAsync(Exception? exception)
        {
            //await this.RemoveFromLobby(Context.ConnectionId);

            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }

        public async Task CreateNewLobby(Player player)
        {
            var lobbyCode = await _lobbyService.CreateLobby(player);
            await Groups.AddToGroupAsync(player.ConnectionId, lobbyCode.ToString());

            await Clients.Group(lobbyCode.ToString()).CreateLobby($"{player.UserName} has created the lobby {lobbyCode}.",
                lobbyCode.ToString());
        }

        public async Task AddToLobby(string lobbyCode, Player player)
        {
            var result = await _lobbyService.AddPlayerToLobby(int.Parse(lobbyCode), player);

            if (result == true)
            {
                await Groups.AddToGroupAsync(player.ConnectionId, lobbyCode);

                await Clients.Group(lobbyCode).JoinLobby($"{player.UserName} has joined the lobby.");

            }
        }

        public async Task GetPlayersInLobby(string lobbyCode)
        {
            var result = await _lobbyService.GetPlayersInLobbyCount(int.Parse(lobbyCode));

            await Clients.Group(lobbyCode).GetPlayerCount(result);
        }

        //public async Task RemoveFromLobby(string connectionId)
        //{
        //    var result = await _lobbyService.RemovePlayerFromLobby(connectionId);

        //    if (result == true)
        //    {
        //        await Groups.RemoveFromGroupAsync(Context.ConnectionId, lobbyCode);
        //        await Clients.Group(lobbyCode).RemoveFromLobby($"{player.UserName} has left the lobby");
        //    }
        //}

// ----------------------------- Game actions
        public async Task GameStart(string lobbyCode)
        {
            await Clients.Group(lobbyCode).GameStartedAction(lobbyCode);
        }
    }
}
