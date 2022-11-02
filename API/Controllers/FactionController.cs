using Application.Interfaces;

namespace API.Controllers;

public class FactionController
{
    private IFactionService _factionService;
    
    public FactionController(IFactionService factionService)
    {
        _factionService = factionService;
    }
}