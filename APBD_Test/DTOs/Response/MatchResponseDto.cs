namespace APBD_Test.DTOs;

public class MatchResponseDto
{
    public TournamentResponseDto TournamentDto { get; set; }
    public MapResponseDto MapDto { get; set; }
    public DateTime MatchDate { get; set; }
    public PlayerMatchResponseDto PlayerMatchDto { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
}


