using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class StratagemController : ControllerBase
{
    private IStratagemService _stratagemService;
    
    public StratagemController(IStratagemService stratagemService)
    {
        _stratagemService = stratagemService;
    }
    
    [HttpGet]
    public List <Stratagem> GetFactions()
    {
        return _stratagemService.GetAllStratagems();
    }

    [HttpPost]
    public Stratagem CreateStratagem(Stratagem stratagem)
    {
        return _stratagemService.CreateStratagem(stratagem);
    }
    
    [HttpPatch]
    public Stratagem UpdateStratagem(Stratagem stratagem)
    {
        return _stratagemService.UpdateStratagem(stratagem);
    }

    [HttpDelete]
    public Boolean DeleteStratagem(Stratagem stratagem)
    {
        return _stratagemService.DeleteStratagem(stratagem);
    }
}