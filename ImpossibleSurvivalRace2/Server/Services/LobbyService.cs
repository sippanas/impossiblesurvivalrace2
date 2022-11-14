using ImpossibleSurvivalRace2.Server.Hubs;
using ImpossibleSurvivalRace2.Shared.Models;

namespace ImpossibleSurvivalRace2.Services
{
    public class LobbyService : ILobbyService
    {
        private readonly Dictionary<int, Lobby> _lobbies = new Dictionary<int, Lobby>();

        public Task<List<Player>> GetPlayers(int lobbyCode)
        {
            return Task.FromResult(_lobbies[lobbyCode].Players);
        }
        public Task<int> CreateLobby(Player creator)
        {
            var code = GenerateLobbyCode();

            _lobbies[code] = new Lobby
            {
                Creator = creator,
                Players = new List<Player>()
            };

            return Task.FromResult(code);
        }

        public Task<bool> AddPlayerToLobby(int lobbyCode, Player player)
        {
            if (_lobbies.ContainsKey(lobbyCode))
            {
                _lobbies[lobbyCode].Players.Add(player);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<bool> RemovePlayerFromLobby(Player player)
        {
            foreach (var code in _lobbies.Keys)
            {
                _lobbies[code].Players.Remove(player);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public Task<int> IsPlayerInAnyLobby(Player player)
        {
            foreach (var code in _lobbies.Keys)
            {
                if (_lobbies[code].Players.Contains(player))
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
