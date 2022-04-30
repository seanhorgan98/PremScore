using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class TeamsDbContext : DbContext
{
    public TeamsDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //DbSet
    public DbSet<Team> Teams { get; set; }
}