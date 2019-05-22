using ProyectoFinal.Entidades;
using System.Data.Entity;

namespace ProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set;  }
        public Contexto() : base("ConStr")
        { }
    }
}
