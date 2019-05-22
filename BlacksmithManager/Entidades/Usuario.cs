using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Entidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Apellido { get; set; }
        public int NivelDeUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaDeIngreso { get; set; }

        public Usuarios()
        {
            IdUsuario = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Email = string.Empty;
            NivelDeUsuario = 0;
            Usuario = string.Empty;
            Clave = string.Empty;
            FechaDeIngreso = DateTime.Now;
        }
    }
}
