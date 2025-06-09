using APBD_Test.DTOs;

namespace APBD_Test.Services;

public interface IDbService
{
    Task<PlayerResponse?> GetPlayerMatchParticipationsAsync(int playerId);
    /*Task AddPlayer(AddPlayerRequest request);*/
}