using APBD_Test.Data;
using APBD_Test.DTOs;
using APBD_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Test.Services;

public class DbService : IDbService
{
    
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context) => _context = context;

    
    public async Task<PlayerResponse?> GetPlayerMatchParticipationsAsync(int playerId)
    {
        var player = await _context.Players.Where(c => c.PlayerId == playerId)
                .Include(p => p.PlayerMatches)
                    .ThenInclude(pm => pm.Match)
                        .ThenInclude(m => m.Tournament)
                .Include(p => p.PlayerMatches)
                    .ThenInclude(pm => pm.Match)
                        .ThenInclude(m => m.Map)
                .Include(p => p.PlayerMatches)
                    .ThenInclude(pm => pm.Player)
                .FirstOrDefaultAsync();

        if (player == null) return null;
        return new PlayerResponse
        {
            PlayerId = player.PlayerId,
            FirstName = player.FirstName,
            LastName = player.LastName,
            BirthDate = player.BirthDate,
            Matches = player.PlayerMatches.Select(m => new MatchResponseDto()
            {
                TournamentDto = new TournamentResponseDto()
                {
                    TournamentName = player.PlayerMatches.FirstOrDefault().Match.Tournament.Name
                },
                MapDto = new MapResponseDto()
                {
                    MapName = player.PlayerMatches.FirstOrDefault().Match.Map.Name
                },
                MatchDate = player.PlayerMatches.FirstOrDefault().Match.MatchDate,
                PlayerMatchDto = new PlayerMatchResponseDto()
                {
                    MVPs = player.PlayerMatches.Where(pm => pm.PlayerId == player.PlayerId).FirstOrDefault().MVPs,
                    Rating =  player.PlayerMatches.Where(pm => pm.PlayerId == player.PlayerId).FirstOrDefault().Rating
                },
                Team1Score = player.PlayerMatches.FirstOrDefault().Match.Team1Score,
                Team2Score = player.PlayerMatches.FirstOrDefault().Match.Team2Score
            }).ToList(),
        };
    }

    /*public async Task AddPlayer(AddPlayerRequest request)
    {

        var existingMatch = await _context.PlayerMatches.FirstOrDefault(m => m.MatchId == request.Matches.FirstOrDefault().MatchId);
        if (existingMatch != null) throw new ArgumentException("Match already exists");
        var existingPlayer = await _context.Players.FirstOrDefaultAsync(p => p.FirstName == request.FirstName && p.LastName == request.LastName && p.BirthDate == request.BirthDate);
        if (existingPlayer != null)
        {
            foreach (MatchRequestDto match in request.Matches)
            {
                if (match.PlayerMatchDto.Rating > request.Matches.Select)
            }
        }
        _context.Players.Add();
        await _context.SaveChangesAsync();
    }*/
}