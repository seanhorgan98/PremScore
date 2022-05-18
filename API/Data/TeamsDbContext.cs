#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //DbSet
    public DbSet<Team> Teams { get; set; }
    public DbSet<Fixture> Fixtures { get; set; }
    public DbSet<Location> Locations { get; set; }
}