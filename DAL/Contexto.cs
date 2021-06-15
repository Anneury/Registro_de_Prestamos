using Microsoft.EntityFrameworkCore;
using Registro_de_Prestamos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_de_Prestamos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        public DbSet<Prestamos> Prestamos { get; set; }

        public DbSet<Moras> Moras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/DatosPersonas.db");
        }
    }
}
