using ImpossibleSurvivalRace2.Services;
using Microsoft.AspNetCore.SignalR;

namespace ImpossibleSurvivalRace2.Hubs
{
    public class GameHub : Hub
    {
        private readonly ILobbyService _lobbyService;

        public GameHub(ILobbyService lobbyService)
        {
            _lobbyService = lobbyService;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task CreateNewLobby()
        {
            var lobbyCode = await _lobbyService.CreateLobby(Context.ConnectionId);
            await Groups.AddToGroupAsync(Context.ConnectionId, lobbyCode.ToString());

            await Clients.Group(lobbyCode.ToString())
                .SendAsync("LobbyCreation", $"{Context.ConnectionId} has created the lobby {lobbyCode}.", lobbyCode.ToString());
        }

        public async Task AddToLobby(string lobbyCode)
        {
            var result = await _lobbyService.AddPlayerToLobby(int.Parse(lobbyCode), Context.ConnectionId);

            if(result == true)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, lobbyCode);
                await Clients.Group(lobbyCode).SendAsync("LobbyJoined", $"{Context.ConnectionId} has joined the lobby.");
            }
        }

        public async Task RemoveFromLobby(string lobbyCode)
        {
            var result = await _lobbyService.RemovePlayerFromLobby(int.Parse(lobbyCode), Context.ConnectionId);

            if(result == true)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, lobbyCode);
                await Clients.Group(lobbyCode).SendAsync("LobbyLeft", $"{Context.ConnectionId} has left the lobby");
            }
        }
    }
}
