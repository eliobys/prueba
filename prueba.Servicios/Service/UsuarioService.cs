using prueba.Entidad;
using prueba.Repositorio.Interface;
using prueba.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Servicio.Service
{
   public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository Repository;

        public UsuarioService(IUsuarioRepository Repository)
        {
            this.Repository = Repository;
        }

        public async Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            return await Repository.ObtenerUsuariosAsync();
        }

    }
}
