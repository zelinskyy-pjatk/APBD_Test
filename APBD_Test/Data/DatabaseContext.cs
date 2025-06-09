using APBD_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Test.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Map> Maps { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Match> Matches { get; set; }
    public DbSet<PlayerMatch> PlayerMatches { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }

    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // -- Map -- // 
        modelBuilder.Entity<Map>().HasData(new List<Map>
        {
            new Map() {MapId = 1, Name = "Map 1", Type = "Political"},
            new Map() {MapId = 2, Name = "Map 2", Type = "Physical" },
            new Map() {MapId = 3, Name = "Map 3", Type = "Topographic"}
        });
        
        // -- Tournament -- //
        modelBuilder.Entity<Tournament>().HasData(new List<Tournament>
        {
            new Tournament() {TournamentId = 1, Name = "Tournament 1", 
                StartDate = new DateTime(2020, 01, 01, 14, 00 ,00), 
                EndDate = new DateTime(2020, 01, 01, 19, 00, 00)},
            new Tournament() {TournamentId = 2, Name = "Tournament 2", 
                StartDate = new DateTime(2022, 05, 01, 08, 30 ,00), 
                EndDate = new DateTime(2022, 05, 04, 15, 00, 00)},
            new Tournament() {TournamentId = 3, Name = "Tournament 3", 
                StartDate = new DateTime(2025, 03, 01, 00, 00 ,00), 
                EndDate = new DateTime(2025, 04, 01, 00, 00, 00)}
        });
        
        // -- Match -- //
        modelBuilder.Entity<Match>().HasData(new List<Match>
        {
            new Match()
            {
                MatchId = 1,
                TournamentId = 1,
                MapId = 1,
                MatchDate = new DateTime(2020, 01, 01, 14, 00 ,00),
                Team1Score = 20,
                Team2Score = 30,
                BestRating = 3.22
            },
            new Match()
            {
                MatchId = 2,
                TournamentId = 2,
                MapId = 3,
                MatchDate = new DateTime(2022, 05, 02, 14, 00 ,00),
                Team1Score = 10,
                Team2Score = 16,
                BestRating = 2.12
            },
            new Match()
            {
                MatchId = 3,
                TournamentId = 2,
                MapId = 2,
                MatchDate = new DateTime(2022, 05, 03, 09, 45 ,00),
                Team1Score = 15,
                Team2Score = 19,
                BestRating = 1.15
            },
            new Match()
            {
                MatchId = 4,
                TournamentId = 3,
                MapId = 2,
                MatchDate = new DateTime(2025, 03, 05, 10, 05 ,00),
                Team1Score = 24,
                Team2Score = 12,
                BestRating = null
            }
        });
        
        // -- Player -- //
        modelBuilder.Entity<Player>().HasData(new List<Player>
        {
            new Player()
            {
                PlayerId = 1,
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new DateTime(2005, 04, 12)
            },
            new Player() { 
                PlayerId = 2,
                FirstName = "Julia",
                LastName = "Mako",
                BirthDate = new DateTime(2001, 05, 20)
                
            },
            new Player() { 
                PlayerId = 3,
                FirstName = "Martin",
                LastName = "Maski",
                BirthDate = new DateTime(2009, 07, 10)
                
            }
        });
        
        // -- Player Match -- //
        modelBuilder.Entity<PlayerMatch>().HasData(new List<PlayerMatch>
        {
            new PlayerMatch()
            {
                MatchId = 1,
                PlayerId = 1,
                MVPs = 1,
                Rating = 2.2
            },
            new PlayerMatch()
            {
                MatchId = 2,
                PlayerId = 3,
                MVPs = 4,
                Rating = 1.2
            },
            new PlayerMatch()
            {
                MatchId = 3,
                PlayerId = 1,
                MVPs = 2,
                Rating = 1.77
            }
        });

        
    }
}