using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialWeb.Models
{
    public class ProyectoViviendaInputModel
    {
        public string Nombre { get; set; }
        public decimal Valor { get; set; }
        public decimal CuotaInicial { get; set; }
    }
    public class ProyectoViviendaViewModel : ProyectoViviendaInputModel
    {
        public int CodProyecto { get; set; }
        public ProyectoViviendaViewModel(ProyectoVivienda proyecto)
        {
            CodProyecto = proyecto.CodProyecto;
            Nombre = proyecto.Nombre;
            CuotaInicial = proyecto.CuotaInicial;
        }
    }

    public class ClienteInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public ProyectoVivienda Proyecto { get; set; }
    }
    public class ClienteViewModel : ClienteInputModel
    {
        public ClienteViewModel(Cliente cliente)
        {
            Identificacion = cliente.Identificacion;
            Nombre = cliente.Nombre;
            Proyecto = cliente.Proyecto;
        }
    }

    public class AbonoInputModel
    {
        public decimal Valor { get; set; }
        public Cliente Cliente { get; set; }
    }
    public class AbonoViewModel : AbonoInputModel
    {
        public int CodAbono { get; set; }

        public AbonoViewModel(Abono abono)
        {
            CodAbono = abono.CodAbono;
            Valor = abono.Valor;
            Cliente = abono.Cliente;
        }
    }
}
