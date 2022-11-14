using ImpossibleSurvivalRace2.Shared.Models;
namespace ImpossibleSurvivalRace2.Services
{
    public interface ILobbyService
    {
        Task<bool> AddPlayerToLobby(int lobbyCode, string playerConnectionId);
        Task<int> CreateLobby(string creatorConnectionId);
        Task<int> IsPlayerInAnyLobby(string playerConnectionId);
        Task<bool> RemovePlayerFromLobby(string playerConnectionId);
        Task<List<string>> GetPlayers(int lobbyCode);
    }
}