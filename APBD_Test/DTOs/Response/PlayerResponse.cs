namespace APBD_Test.DTOs;

public class PlayerResponse
{
    public int PlayerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<MatchResponseDto> Matches { get; set; }
}