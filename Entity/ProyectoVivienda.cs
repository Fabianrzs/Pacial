using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class ProyectoVivienda
    {
        [Key]
        public int CodProyecto { get; set; }
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public decimal CuotaInicial { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

    }
}
