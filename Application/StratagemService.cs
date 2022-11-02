using Application.Interfaces;
using Domain;

namespace Application;

public class StratagemService : IStratagemService
{
    private IStratagemService _stratagemService;
    
    public StratagemService(IStratagemService stratagemService)
    {
        _stratagemService = stratagemService;
    }

    public List<Stratagem> GetAllStratagems()
    {
        throw new NotImplementedException();
    }

    public Stratagem GetStratagemById(int id)
    {
        throw new NotImplementedException();
    }

    public Stratagem GetStratagemByUnit(Unit unit)
    {
        throw new NotImplementedException();
    }

    public Stratagem CreateStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }

    public Stratagem UpdateStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }

    public void DeleteStratagem(int id)
    {
        throw new NotImplementedException();
    }
}