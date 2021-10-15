using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Cliente
    {
        [Key]
        public string Identificacion { get; set; }
        public string Nombre { get; set; }

        [Required]
        public int CodProyecto { get; set; }
        public ProyectoVivienda Proyecto { get; set; }

        public ICollection<Abono> Abonos { get; set; }
    }
}
