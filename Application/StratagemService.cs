using Application.Interfaces;
using Domain;

namespace Application;

public class StratagemService : IStratagemService
{
    private IStratagemRepository _stratagemRepository;
    
    public StratagemService(IStratagemRepository stratagemRepository)
    {
        _stratagemRepository = stratagemRepository;

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

    public bool DeleteStratagem(Stratagem stratagem)
    {
        throw new NotImplementedException();
    }
}