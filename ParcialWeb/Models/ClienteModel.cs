using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialWeb.Models
{
    public class ClienteInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int CodProyecto { get; set; }
    }
    public class ClienteViewModel : ClienteInputModel
    {
        public ClienteViewModel(Cliente cliente)
        {
            Identificacion = cliente.Identificacion;
            Nombre = cliente.Nombre;
            CodProyecto = cliente.CodProyecto;
        }
    }
}
