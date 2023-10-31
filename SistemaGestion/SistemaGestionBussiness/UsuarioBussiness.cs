using SistemaGestionData;
using SistemaGestionEntities;
using SistemaGestionEntities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static UsuarioResponse CrearUsuario(Usuario usuario)
        {
            return UsuarioData.CrearUsuario(usuario);
        }

        public static UsuarioResponse ModificarUsuario(Usuario usuario)
        {
            return UsuarioData.ModificarUsuario(usuario);
        }

        public static UsuarioResponse EliminarUsuario(int Id)
        {
            return UsuarioData.EliminarUsuario(Id);
        }

        //TRAER NOMBRE
        public static List<Usuario> TraerNombre(string user, string password)
        {
            return UsuarioData.TraerNombre(user, password);
        }

        //nombreUsuario
        //public static List<Usuario> ObtenerNombreUsuario(int Id)
        //{
        //    return UsuarioData.ObtenerNombreUsuario(Id);
        //}


        //public static List<Usuario> ValidarUsuario(string user)
        //{
        //    return UsuarioData.ValidarUsuario(user);
        //}

    }
}
