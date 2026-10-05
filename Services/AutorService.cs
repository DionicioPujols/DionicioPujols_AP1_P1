using DionicioPujols_AP1_P1.Context;
using DionicioPujols_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DionicioPujols_AP1_P1.Services;

public class AutorService(IDbContextFactory<Contexto>
contextFactory) : Aplicada1.Core.IService<Autor, int>
{

    public async Task<bool> Guardar(Autor autorId)
    {
       if(!await Existe(autorId.IdAutor))
       {
            return await Insertar(autorId);
       }
       else
       {
            return await Modificar(autorId);
       } 
    }

    public async Task<bool> Existe(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .AnyAsync(a => a.IdAutor == autorId);
    }

    public async Task<bool> Insertar(Autor autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Autores.Add(autorId);
        return await contexto
            .SaveChangesAsync() > 0;
    }

    public async Task<bool> Modificar(Autor autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        contexto.Update(autorId);
        return await contexto
            .SaveChangesAsync() > 0;
    }

    public async Task<Autor?> Buscar(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .FirstOrDefaultAsync(a => a.IdAutor == autorId);
    }

    public async Task<List<Autor>> GetList(Expression<Func<Autor, bool>> criterio)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(criterio)
            .AsNoTracking()
            .ToListAsync();
    }
    public async Task<bool> Eliminar(int autorId)
    {
        await using var contexto = await contextFactory.CreateDbContextAsync();
        return await contexto.Autores
            .Where(a => a.IdAutor == autorId)
            .ExecuteDeleteAsync() > 0;
    }

}
