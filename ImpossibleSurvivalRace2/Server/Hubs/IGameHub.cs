using ImpossibleSurvivalRace2.Shared.Models;

namespace ImpossibleSurvivalRace2.Server.Hubs
{
    public interface IGameHub
    {
        Task ReceiveMessage(string user, string message);
        Task CreateLobby(string message, string lobbyCode);
        Task JoinLobby(string message);
        Task GetPlayerCount(int playerCount);
        Task RemoveFromLobby(string message);

        // Game actions
        // ------------
        // SpawnPlayer
        Task GameStartedAction(string lobbyCode);
    }
}