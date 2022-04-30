using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Team
{
    [Key]
    public Guid Id { get; set; }

    public string TeamName { get; set; }
    public string Sponsor { get; set; }
    public int Points { get; set; }
}