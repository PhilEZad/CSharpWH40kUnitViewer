using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase
{
    private IUnitService _unitService;

    public UnitController(IUnitService service)
    {
        _unitService = service;
    }

    [HttpGet]
    public List<Unit> GetUnits()
    {
            return _unitService.GetAllUnits();
    }
    
    [HttpPost]
    public Unit AddUnit(Unit unit)
    {
        return _unitService.AddUnit(unit);
    }
    
    [HttpDelete]
    public Boolean DeleteUnit(Unit unit)
    {
        return _unitService.DeleteUnit(unit);
    }
}