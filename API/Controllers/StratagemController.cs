using Application.Interfaces;

namespace API.Controllers;

public class StratagemController
{
    private IStratagemService _stratagemService;
    
    public StratagemController(IStratagemService stratagemService)
    {
        _stratagemService = stratagemService;
    }
    
}