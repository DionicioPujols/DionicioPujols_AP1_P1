using DionicioPujols_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace DionicioPujols_AP1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    public DbSet<Autor> Autores { get; set; }
}
