using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class FactionController : ControllerBase
{
    private IFactionService _factionService;
    
    
    public FactionController(IFactionService factionService)
    {
        _factionService = factionService;
    }

    [HttpGet]
    public List<Faction> GetAllFactions()
    {
            return _factionService.GetAllFactions();
    }
    
    [HttpPost]
    public Faction CreateFaction(Faction faction)
    {
        return _factionService.CreateFaction(faction);
    }
    
    [HttpPatch]
    [Route("{id}")]
    public ActionResult<Faction> UpdateFaction([FromRoute] int id, [FromBody] Faction faction)
    {
        try
        {
            return _factionService.UpdateFaction(id, faction);
        }
        catch (KeyNotFoundException e)
        {
            return NotFound("No faction with that ID can be found" + id);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }
    
    [HttpDelete]
    public bool DeleteFaction(Faction faction)
    {
        return _factionService.DeleteFaction(faction);
    }

    [HttpGet]
    [Route("buildDB")]
    public void buildDB()
    {
        _factionService.BuildDb();
    }
}