using BLL;
using DAL;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parcialWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private ProyectoService service;

        public ProyectoController(ProyectoContext context)
        {
            service = new ProyectoService(context);
        }

        [HttpGet]
        public ActionResult<List<ProyectoVivienda>> ConsultaProyectos()
        {
            var respuesta = service.ConsultarProyectos();
            if (respuesta.Error) return BadRequest(respuesta.Mensaje);
            return Ok(respuesta.Proyectos);
        }

    }
}
