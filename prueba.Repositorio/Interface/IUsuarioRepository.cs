using prueba.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Repositorio.Interface
{
  public  interface IUsuarioRepository
    {
        Task<List<Usuario>> ObtenerUsuariosAsync();
    }
}
