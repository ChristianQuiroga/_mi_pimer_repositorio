using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioAccesoController : ControllerBase
    {
        //GET
        [HttpGet(Name = "ListarNombreUsuario")]
        public IEnumerable<Usuario> get(string user, string password)
        {
            return UsuarioBussiness.TraerNombre(user, password).ToArray();

        }

        //Get
        //[HttpGet(Name ="ValidarUsuario")]
        //public IEnumerable<Usuario> get(string user)
        //{
        //    return UsuarioBussiness.ValidarUsuario(user).ToArray();
        //}

        //Get nombre
        //[HttpGet(Name = "ListarNombreUsuario")]
        //public void Get([FromBody] int Id)
        //public IEnumerable<Usuario> get(int Id)
        //{
        //    return UsuarioBussiness.ObtenerNombreUsuario(Id).ToArray();

        //}
    }
}
