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
    public class ProyectoViviendaViewModel: ProyectoViviendaInputModel
    {
        public int CodProyecto { get; set; }
        public ProyectoViviendaViewModel(ProyectoVivienda proyecto)
        {
            CodProyecto = proyecto.CodProyecto;
            Nombre = proyecto.Nombre;
            CuotaInicial = proyecto.CuotaInicial;
        }
    }
}
