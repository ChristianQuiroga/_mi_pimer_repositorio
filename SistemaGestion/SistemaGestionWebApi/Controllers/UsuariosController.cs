using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        //Get
        [HttpGet(Name = "ListarUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.ListarUsuarios().ToArray();

        }

        //Post - Insertar
        [HttpPost(Name = "AltaUsuarios")]
        public void Post([FromBody] Usuario usuario)  //los parámetros van en el Body
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }


        //Put - Modificar
        [HttpPut(Name = "ModificarUsuarios")]
        public void Put([FromBody] Usuario usuario)  //los parámetros van en el Body
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }

        //Delete
        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] Usuario usuario)  //los parámetros van en el Body
        {
            UsuarioBussiness.EliminarUsuario(usuario);
        }

    }
}
