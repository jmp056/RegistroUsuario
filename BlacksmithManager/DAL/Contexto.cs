using ProyectoFinal.Entidades;
using System.Data.Entity;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set;  }
        public Contexto() : base("ConStr")
        { }
    }
}
