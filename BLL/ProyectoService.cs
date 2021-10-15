using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ProyectoService
    {
        private readonly ProyectoContext _context;

        public ProyectoService(ProyectoContext context)
        {
            _context = context;
        }

        public ProyectoViviendaConsultaResponse ConsultarProyectos()
        {
            try
            {
                return new ProyectoViviendaConsultaResponse(_context.Proyectos.ToList());
            }
            catch (Exception e) { return new ProyectoViviendaConsultaResponse($"Error al consultar {e}"); }
        }

        public class ProyectoViviendaConsultaResponse
        {
            public List<ProyectoVivienda> Proyectos { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ProyectoViviendaConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

            public ProyectoViviendaConsultaResponse(List<ProyectoVivienda> proyectos)
            {
                Proyectos = proyectos;
                Error = false;  
            }

        }

        public LogAbonoResponse RagistrarAbono(Abono abono)
        {
            try
            {
                if (_context.Clientes.Find(abono.IdCliente) == null)
                {
                    return new LogAbonoResponse($"Advertencia no se encontro el cliente {abono.IdCliente}");
                }

                _context.Add(abono);
                _context.SaveChangesAsync();
                return new LogAbonoResponse(abono);
            }
            catch (Exception e){ return new LogAbonoResponse($"Error al registrar el abono {e}"); }
        }

        public class LogAbonoResponse
        {
            public Abono Abono { get; set; }
            public string  Mensaje { get; set; }
            public bool Error { get; set; }

            public LogAbonoResponse(Abono abono)
            {
                Abono = abono;
                Error = false;
            }

            public LogAbonoResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        }

        public AbonoConsultaResponse ConsultarAbonos()
        {
            try
            {
                return new AbonoConsultaResponse(_context.Abonos.ToList());
            }
            catch (Exception e) { return new AbonoConsultaResponse($"Error al Consultar los abonos {e}"); }
        }

        public class AbonoConsultaResponse
        {
            public List<Abono> Abonos { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public AbonoConsultaResponse(List<Abono> abonos)
            {
                Abonos = abonos;
                Error = false;
            }

            public AbonoConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }


        public LogClienteResponse RegistrarCliente(Cliente cliente)
        {
            try
            {

                if (_context.Clientes.Find(cliente.Identificacion) != null)
                {
                    return new LogClienteResponse($"El cliente ya se encuentra registrado");
                }

                _context.Clientes.Add(cliente);
                return new LogClienteResponse(cliente);
            }
            catch (Exception e) { return new LogClienteResponse( $"Error al registrar el Cliente {e}"); }

        }

        public class LogClienteResponse
        {
            public Cliente Cliente { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public LogClienteResponse(Cliente cliente)
            {
                Cliente = cliente;
                Error = false;
            }

            public LogClienteResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }

        public ClienteConsultaResponse ConsultarClientes()
        {
            try
            {
                return new ClienteConsultaResponse(_context.Clientes.ToList());
            }
            catch (Exception e) { return new ClienteConsultaResponse($"Error al Consultar los clientes {e}"); }
        }

        public class ClienteConsultaResponse
        {
            public List<Cliente> Clientes { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ClienteConsultaResponse(List<Cliente> clientes)
            {
                Clientes = clientes;
                Error = false;
            }

            public ClienteConsultaResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }

    }
}
