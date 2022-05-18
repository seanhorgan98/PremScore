#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public class Team
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string TeamName { get; set; }
    public string Abbreviation { get; set; }
    public string Sponsor { get; set; }
    public int SeasonPlayed { get; set; }
    public int SeasonWon { get; set; }
    public int SeasonDrawn { get; set; }
    public int SeasonLost { get; set; }
    public int SeasonGoalsFor { get; set; }
    public int SeasonGoalsAgainst { get; set; }
    public int SeasonGoalDifference { get; set; }
    public int SeasonPoints { get; set; }
    public int TotalPlayed { get; set; }
    public int TotalWon { get; set; }
    public int TotalDrawn { get; set; }
    public int TotalLost { get; set; }
    public int TotalGoalsFor { get; set; }
    public int TotalGoalsAgainst { get; set; }
    public int TotalGoalDifference { get; set; }
    public int TotalPoints { get; set; }
    public int LeaguePosition { get; set; }
}