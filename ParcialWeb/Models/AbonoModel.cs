using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialWeb.Models
{
    public class AbonoInputModel
    {
        public decimal Valor { get; set; }
        public string IdCliente { get; set; }
    }
    public class AbonoViewModel: AbonoInputModel
    {
        public int CodAbono { get; set; }

        public AbonoViewModel(Abono abono)
        {
            CodAbono = abono.CodAbono;
            Valor = abono.Valor;
            IdCliente = abono.IdCliente;
        }
    }
}

