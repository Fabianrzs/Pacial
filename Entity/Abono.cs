using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Abono
    {
        [Key]
        public int CodAbono { get; set; }
        public decimal Valor { get; set; }

        [Required]
        public string IdCliente { get; set; }
        public Cliente Cliente { get; set; }

    }
}
