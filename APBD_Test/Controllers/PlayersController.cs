using APBD_Test.DTOs;
using APBD_Test.Models;
using APBD_Test.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Test.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly IDbService _dbService;
    public PlayersController(IDbService dbService) => _dbService = dbService;


    [HttpGet("/{id}/matches")]
    public async Task<IActionResult> GetPlayerMatches(int id)
    {
        var result = await _dbService.GetPlayerMatchParticipationsAsync(id);
        if (result == null) return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddPlayer([FromBody] AddPlayerRequest playerRequest)
    {
        try
        {
            await _dbService.AddPlayer(playerRequest);
            return Created();
        }
        catch (ArgumentException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e) {
            return StatusCode(500, "An unexpected error occured");
        }
    }
}