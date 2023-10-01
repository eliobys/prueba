using prueba.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Servicio.Interface
{
   public interface IUsuarioService
    {
        Task<List<Usuario>> ObtenerUsuariosAsync();
    }
}
