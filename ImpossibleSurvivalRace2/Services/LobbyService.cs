using ImpossibleSurvivalRace2.Hubs;
using ImpossibleSurvivalRace2.Models;
using Microsoft.AspNetCore.SignalR;

namespace ImpossibleSurvivalRace2.Services
{
    public class LobbyService : ILobbyService
    {
        private readonly Dictionary<int, Lobby> _lobbies = new Dictionary<int, Lobby>();

        public Task<int> CreateLobby(string creatorConnectionId)
        {
            var code = GenerateLobbyCode();

            _lobbies[code] = new Lobby
            {
                CreatorConnectionId = creatorConnectionId,
                Players = new List<string>()
            };

            return Task.FromResult(code);
        }

        public Task<bool> AddPlayerToLobby(int lobbyCode, string playerConnectionId)
        {
            if (_lobbies.ContainsKey(lobbyCode))
            {
                _lobbies[lobbyCode].Players.Add(playerConnectionId);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<bool> RemovePlayerFromLobby(string playerConnectionId)
        {
            foreach (var code in _lobbies.Keys)
            {
                _lobbies[code].Players.Remove(playerConnectionId);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<int> IsPlayerInAnyLobby(string playerConnectionId)
        {
            foreach (var code in _lobbies.Keys)
            {
                if (_lobbies[code].Players.Contains(playerConnectionId))
                {
                    return Task.FromResult(code);
                }
            }

            return Task.FromResult(0);
        }

        private int GenerateLobbyCode()
        {
            Random random = new Random();
            int generatedCode = random.Next(10000, 99999);

            return generatedCode;
        }
    }
}
