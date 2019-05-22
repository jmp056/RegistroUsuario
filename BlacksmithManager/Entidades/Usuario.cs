using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Apellido { get; set; }
        public int NivelDeUsuario { get; set; }
        public string NUsuario { get; set; }
        public string Clave { get; set; }
        public DateTime FechaDeIngreso { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Email = string.Empty;
            NivelDeUsuario = 0;
            NUsuario = string.Empty;
            Clave = string.Empty;
            FechaDeIngreso = DateTime.Now;
        }
    }
}
