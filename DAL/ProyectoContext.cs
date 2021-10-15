using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProyectoContext:DbContext
    {
        public ProyectoContext(DbContextOptions options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Abono>()
                .HasOne<Cliente>(a => a.Cliente)
                .WithMany(c => c.Abonos)
                .HasForeignKey(a => a.IdCliente);

            model.Entity<Cliente>()
                .HasOne<ProyectoVivienda>(c => c.Proyecto)
                .WithMany(p => p.Clientes)
                .HasForeignKey(c => c.CodProyecto);            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Abono> Abonos { get; set; }
        public DbSet<ProyectoVivienda> Proyectos { get; set; }

    }
}
