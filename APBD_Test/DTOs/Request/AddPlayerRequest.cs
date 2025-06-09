using APBD_Test.Models;

namespace APBD_Test.DTOs;

public class AddPlayerRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public double Rating { get; set; }
    public List<MatchRequestDto> Matches { get; set; }
}