using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntityFramework
{
    public class SistemaGestionContext :DbContext //Hereda del paquete que instalamos Donet (entity framework)
    {
        //add las clases a migrar
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Producto> Productos { get; set;}
        public DbSet<ProductoVendido> ProductoVendidos { get; set;}
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Venta> Ventas { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Cadena de conexión
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database = SistemaGestionEF; Trusted_Connection = True"); //lacaldb base local para trabajar con VStudio


            //base.OnConfiguring(optionsBuilder);
        }
    }
}
