using Domain;

namespace Application.Interfaces;

public interface IFactionService
{
    public List<Faction> GetAllFactions();
    public Faction GetFactionById(int id);
    public Faction CreateFaction(Faction faction);
    public Faction UpdateFaction(int id, Faction faction);
    public Boolean DeleteFaction(Faction faction);
    public void BuildDb();
}