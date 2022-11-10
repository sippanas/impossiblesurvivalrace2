using ImpossibleSurvivalRace2.Services;
using Microsoft.AspNetCore.SignalR;

namespace ImpossibleSurvivalRace2.Server.Hubs
{
    public class GameHub : Hub<IGameHub>
    {
        private readonly ILobbyService _lobbyService;

        public GameHub(ILobbyService lobbyService)
        {
            _lobbyService = lobbyService;
        }

        public override async Task<Task> OnDisconnectedAsync(Exception? exception)
        {
            await this.RemoveFromLobby(Context.ConnectionId);

            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
        }

        public async Task CreateNewLobby()
        {
            var lobbyCode = await _lobbyService.CreateLobby(Context.ConnectionId);
            await Groups.AddToGroupAsync(Context.ConnectionId, lobbyCode.ToString());

            await Clients.Group(lobbyCode.ToString()).CreateLobby($"{Context.ConnectionId} has created the lobby {lobbyCode}.", 
                lobbyCode.ToString());
        }

        public async Task AddToLobby(string lobbyCode)
        {
            var result = await _lobbyService.AddPlayerToLobby(int.Parse(lobbyCode), Context.ConnectionId);

            if (result == true)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, lobbyCode);

                await Clients.Group(lobbyCode).JoinLobby($"{Context.ConnectionId} has joined the lobby.");
            }
        }

        public async Task RemoveFromLobby(string lobbyCode)
        {
            var result = await _lobbyService.RemovePlayerFromLobby(Context.ConnectionId);

            if (result == true)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, lobbyCode);
                await Clients.Group(lobbyCode).RemoveFromLobby($"{Context.ConnectionId} has left the lobby");
            }
        }
    }
}
