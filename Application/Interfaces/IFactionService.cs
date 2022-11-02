using Domain;

namespace Application.Interfaces;

public interface IFactionService
{
    public List<Faction> GetAllFactions();
    public Faction GetFactionById(int id);
    public Faction CreateFaction(Faction faction);
    public Faction UpdateFaction(Faction faction);
    public Boolean DeleteFaction(Faction faction);
}