#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public class Fixture
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public DateTime Date { get; set; }
    public int TeamOneId { get; set; }
    public int TeamTwoId { get; set; }
    public Team TeamOne { get; set; }
    public Team TeamTwo { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
}