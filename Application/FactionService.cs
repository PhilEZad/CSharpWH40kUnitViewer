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
        throw new NotImplementedException();
    }

    public Faction GetFactionById(int id)
    {
        throw new NotImplementedException();
    }

    public Faction CreateFaction(Faction faction)
    {
        throw new NotImplementedException();
    }

    public Faction UpdateFaction(Faction faction)
    {
        throw new NotImplementedException();
    }

    public bool DeleteFaction(Faction faction)
    {
        throw new NotImplementedException();
    }
}