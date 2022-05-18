using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FixturesController : Controller
{
    private readonly ApplicationDbContext _context;

    public FixturesController(ApplicationDbContext fixturesDbContext)
    {
        _context = fixturesDbContext;
    }
    
    // GET all Fixtures
    [HttpGet]
    public async Task<IActionResult> GetAllFixtures()
    {
        var fixtures = await _context.Fixtures.OrderBy(x => x.Date).ToListAsync();
        return Ok(fixtures);
    }
    
    // GET Single Fixture
    [HttpGet]
    [Route("{id:int}")]
    [ActionName("GetFixture")]
    public async Task<IActionResult> GetFixture([FromRoute] int id)
    {
        var fixtures = await _context.Fixtures.FirstOrDefaultAsync(x => x.Id == id);
        if (fixtures != null)
        {
            return Ok(fixtures);
        }
        else
        {
            return NotFound("Fixture not found in database.");
        }
    }
    
    // POST Single Fixture
    [HttpPost]
    public async Task<IActionResult> AddFixture([FromBody] Fixture fixture)
    {
        await _context.Fixtures.AddAsync(fixture);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetFixture), new { id = fixture.Id }, fixture);
    }
    
    // UPDATE Single Fixture
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateFixture([FromRoute] int id, [FromBody] Fixture fixture)
    {
        var existingFixture = await _context.Fixtures.FirstOrDefaultAsync(x => x.Id == id);
        if (existingFixture != null)
        {
            existingFixture.Date = fixture.Date;
            existingFixture.TeamOne = fixture.TeamOne;
            existingFixture.TeamTwo = fixture.TeamTwo;
            existingFixture.Location = fixture.Location;
            await _context.SaveChangesAsync();
            return Ok(existingFixture);
        }
        else
        {
            return NotFound("Fixture not found in database.");
        }
    }
    
    // Delete Single Fixture
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> DeleteFixture([FromRoute] int id)
    {
        var existingFixture = await _context.Fixtures.FirstOrDefaultAsync(x => x.Id == id);
        if (existingFixture != null)
        {
            _context.Remove(existingFixture);
            await _context.SaveChangesAsync();
            return Ok(existingFixture);
        }
        else
        {
            return NotFound("Fixture not found in database.");
        }
    }
    
    // GET Upcoming fixtures
    [HttpGet]
    [Route("/api/Fixtures/upcoming")]
    public async Task<IActionResult> GetUpcomingFixtures()
    {
        var fixtures = await _context.Fixtures
            .OrderBy(x => x.Date)
            .Where(x => x.Date.Date > DateTime.Now.Date)
            .Take(6)
            .ToListAsync();
        return Ok(fixtures);
    }
}