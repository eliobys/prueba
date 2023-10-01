using Microsoft.EntityFrameworkCore;
using prueba.Entidad;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Repositorio.Context
{
   public class DbContextPrueba :DbContext
    {
        public DbContextPrueba(DbContextOptions options) : base(options)
        {
           
        }
        public virtual DbSet<Usuario>Usuario { get; set; }
    }
}
