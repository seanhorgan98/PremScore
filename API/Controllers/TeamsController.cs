using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamsController : Controller
{
    private readonly ApplicationDbContext _context;

    public TeamsController(ApplicationDbContext teamsDbContext)
    {
        _context = teamsDbContext;
    }
    
    // Get all Teams
    [HttpGet]
    public async Task<IActionResult> GetAllTeams()
    {
        var teams = await _context.Teams.OrderBy(x => x.LeaguePosition).ToListAsync();
        return Ok(teams);
    }
    
    // GET Single Team
    [HttpGet]
    [Route("{id:int}")]
    [ActionName("GetTeam")]
    public async Task<IActionResult> GetTeam([FromRoute] int id)
    {
        var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
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
        await _context.Teams.AddAsync(team);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTeam), new { id = team.Id }, team);
    }
    
    // Update Single Team
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateTeam([FromRoute] int id, [FromBody] Team team)
    {
        var existingTeam = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (existingTeam != null)
        {
            existingTeam.TeamName = team.TeamName;
            existingTeam.Abbreviation = team.Abbreviation;
            existingTeam.Sponsor = team.Sponsor;
            existingTeam.SeasonPlayed = team.SeasonPlayed;
            existingTeam.SeasonWon = team.SeasonWon;
            existingTeam.SeasonDrawn = team.SeasonDrawn;
            existingTeam.SeasonLost = team.SeasonLost;
            existingTeam.SeasonGoalsFor = team.SeasonGoalsFor;
            existingTeam.SeasonGoalsAgainst = team.SeasonGoalsAgainst;
            existingTeam.SeasonGoalDifference = team.SeasonGoalDifference;
            existingTeam.SeasonPoints = team.SeasonPoints;
            existingTeam.TotalPlayed = team.TotalPlayed;
            existingTeam.TotalWon = team.TotalWon;
            existingTeam.TotalDrawn = team.TotalDrawn;
            existingTeam.TotalLost = team.TotalLost;
            existingTeam.TotalGoalsFor = team.TotalGoalsFor;
            existingTeam.TotalGoalsAgainst = team.TotalGoalsAgainst;
            existingTeam.TotalGoalDifference = team.TotalGoalDifference;
            existingTeam.TotalPoints = team.TotalPoints;
            existingTeam.LeaguePosition = team.LeaguePosition;
            await _context.SaveChangesAsync();
            return Ok(existingTeam);
        }
        else
        {
            return NotFound("Team not found in database.");
        }
    }
    
    // Delete Single Team
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> DeleteTeam([FromRoute] int id)
    {
        var existingTeam = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (existingTeam != null)
        {
            _context.Remove(existingTeam);
            await _context.SaveChangesAsync();
            return Ok(existingTeam);
        }
        else
        {
            return NotFound("Team not found in database.");
        }
    }
}