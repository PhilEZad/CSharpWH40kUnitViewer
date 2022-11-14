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
    
    [HttpGet]
    [Route("{id}")]
    public Unit GetUnit(int id)
    {
        return _unitService.GetUnitById(id);
    }

    [HttpPost]
    [Route("{faction}")]
    public List<Unit> GetUnitsByFaction(Faction faction)
    {
        return _unitService.GetUnitsByFaction(faction);
    }
    
    [HttpPost]
    public Unit AddUnit(Unit unit)
    {
        return _unitService.AddUnit(unit);
    }
    
    [HttpPatch]
    public Unit UpdateUnit(Unit unit)
    {
        return _unitService.UpdateUnit(unit);
    }
    
    [HttpDelete]
    [Route("{id}")]
    public bool DeleteUnit(int id)
    {
        return _unitService.DeleteUnit(id);
    }
}