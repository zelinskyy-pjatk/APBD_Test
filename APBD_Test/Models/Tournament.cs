﻿using System.ComponentModel.DataAnnotations;

namespace APBD_Test.Models;

public class Tournament
{
    [Key]
    public int TournamentId { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }   
    
    public ICollection<Match> Matches { get; set; }
}