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
        public DbSet<Cliente> Clientes { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Cadena de conexión
            optionsBuilder.UseSqlServer(@"(localdb)\mssqllocaldb;Database = SistemaGestionEF; Trusted_Connection = True");


            //base.OnConfiguring(optionsBuilder);
        }
    }
}
