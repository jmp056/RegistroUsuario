using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Cargos
    {
        [Key]
        public int IdCargo { get; set; }
        public string DescripcionCargo { get; set; }

        public Cargos()
        {
            IdCargo = 0;
            DescripcionCargo = string.Empty;
        }


    }
}
