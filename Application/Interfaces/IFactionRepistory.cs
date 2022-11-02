using Domain;

namespace Application.Interfaces;

public interface IFactionRepistory
{
    public List<Faction> GetAllFactions();
    public Faction CreateFaction(Faction faction);
    public Boolean UpdateFaction(Faction faction);
    public Faction GetFactionById(int id);
    public Boolean DeleteFaction(Faction faction);
}