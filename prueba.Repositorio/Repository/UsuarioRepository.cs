using Microsoft.EntityFrameworkCore;
using prueba.Entidad;
using prueba.Repositorio.Context;
using prueba.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Repositorio.Repository
{
   
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbContextPrueba dbContext;

        public UsuarioRepository(DbContextPrueba dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            return dbContext.Usuario.ToListAsync();
        }
    }
}
