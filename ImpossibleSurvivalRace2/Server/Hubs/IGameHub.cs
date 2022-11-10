﻿namespace ImpossibleSurvivalRace2.Server.Hubs
{
    public interface IGameHub
    {
        Task ReceiveMessage(string user, string message);
        Task CreateLobby(string message, string lobbyCode);
        Task JoinLobby(string message);
        Task RemoveFromLobby(string message);
    }
}