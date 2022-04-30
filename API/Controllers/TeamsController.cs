using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : Controller
{
    private readonly TeamsDbContext _teamsDbContext;

    public TeamsController(TeamsDbContext teamsDbContext)
    {
        _teamsDbContext = teamsDbContext;
    }
    
    // Get all Teams
    [HttpGet]
    public async Task<IActionResult> GetAllTeams()
    {
        var teams = await _teamsDbContext.Teams.ToListAsync();
        return Ok(teams);
    }
    
    // GET Single Team
    [HttpGet]
    [Route("{id:guid}")]
    [ActionName("GetTeam")]
    public async Task<IActionResult> GetTeam([FromRoute] Guid id)
    {
        var team = await _teamsDbContext.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (team != null)
        {
            return Ok(team);
        }
        else
        {
            return NotFound("Team not found in database.");
        }
    }
    
    // POST Single Team
    [HttpPost]
    public async Task<IActionResult> AddTeam([FromBody] Team team)
    {
        team.Id = Guid.NewGuid();
        await _teamsDbContext.Teams.AddAsync(team);
        await _teamsDbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTeam), new { id = team.Id }, team);
    }
}