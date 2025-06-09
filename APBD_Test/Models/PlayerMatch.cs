using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Test.Models;

[PrimaryKey(nameof(MatchId), nameof(PlayerId))]
[Table("Player_Match")]
public class PlayerMatch
{
    [ForeignKey(nameof(Match))]
    public int MatchId { get; set; }
    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }
    public int MVPs { get; set; }
    [Column(TypeName = "decimal")]
    [Precision(10, 2)]
    public double Rating { get; set; }
    
    public Match Match { get; set; }
    public Player Player { get; set; }
}