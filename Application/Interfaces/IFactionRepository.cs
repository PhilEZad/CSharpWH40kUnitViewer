using Domain;

namespace Application.Interfaces;

public interface IFactionRepository
{
    public List<Faction> GetAllFactions();
    public Faction GetFactionById(int id);
    public Faction CreateFaction(Faction faction);
    public Boolean UpdateFaction(Faction faction);
    public Boolean DeleteFaction(Faction faction);
}