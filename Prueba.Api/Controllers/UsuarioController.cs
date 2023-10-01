using Microsoft.AspNetCore.Mvc;
using prueba.Entidad;
using prueba.Servicio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Api.Controllers
{
    [ApiController ]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpGet]
        [Route("Get")]
        // GET api/values
        public Task<List<Usuario>> Get()
        {
            return usuarioService.ObtenerUsuariosAsync();
        }
    }
}
