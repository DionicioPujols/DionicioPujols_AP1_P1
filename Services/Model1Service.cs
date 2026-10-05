using DionicioPujols_AP1_P1.Context;
using DionicioPujols_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DionicioPujols_AP1_P1.Services;

public class Model1Service(IDbContextFactory<Contexto>
contextFactory) : Aplicada1.Core.IService<Autor, int>
{
    public Task<Autor?> Buscar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Guardar(Autor entidad)
    {
        throw new NotImplementedException();
    }
}
