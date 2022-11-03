using Application.Interfaces;
using Domain;

namespace Application;

public class FactionService : IFactionService
{
    private IFactionRepository _factionRepository;
    public FactionService(IFactionRepository factionRepository)
    {
        _factionRepository = factionRepository;
    }

    public List<Faction> GetAllFactions()
    {
        return _factionRepository.GetAllFactions();
    }

    public Faction GetFactionById(int id)
    {
        return _factionRepository.GetFactionById(id);
    }

    public Faction CreateFaction(Faction faction)
    {
        return _factionRepository.CreateFaction(faction);
    }

    public Faction UpdateFaction(int id, Faction faction)
    {
        return _factionRepository.UpdateFaction(faction);
    }

    public bool DeleteFaction(Faction faction)
    {
        return _factionRepository.DeleteFaction(faction);
    }
    
    public void BuildDb()
    {
        _factionRepository.BuildDb();
    }
}