namespace ImpossibleSurvivalRace2.Services
{
    public interface ILobbyService
    {
        Task<bool> AddPlayerToLobby(int lobbyCode, string playerConnectionId);
        Task<int> CreateLobby(string creatorConnectionId);
        Task<bool> RemovePlayerFromLobby(int lobbyCode, string playerConnectionId);
    }
}