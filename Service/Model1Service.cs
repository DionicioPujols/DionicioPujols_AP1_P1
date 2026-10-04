using DionicioPujols_AP1_P1.Context;
using DionicioPujols_AP1_P1.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DionicioPujols_AP1_P1.Service;

public class Model1Service(IDbContextFactory<Contexto>
contextFactory) : Aplicada1.Core.IService<Model1, int>
{
    public Task<Model1?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Model1>> GetList(Expression<Func<Model1, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Model1 entidad)
    {
        throw new NotImplementedException();
    }
}
