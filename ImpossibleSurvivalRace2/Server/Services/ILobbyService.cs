using ImpossibleSurvivalRace2.Shared.Models;

namespace ImpossibleSurvivalRace2.Services
{
    public interface ILobbyService
    {
        Task<bool> AddPlayerToLobby(int lobbyCode, Player player);
        Task<int> CreateLobby(Player creator);
        Task<int> IsPlayerInAnyLobby(Player player);
        Task<bool> RemovePlayerFromLobby(Player player);
    }
}