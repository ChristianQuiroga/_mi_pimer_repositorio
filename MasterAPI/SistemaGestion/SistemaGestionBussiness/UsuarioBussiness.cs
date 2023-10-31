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

        public static UsuarioResponse EliminarUsuario(Usuario usuario)
        {
            return UsuarioData.EliminarUsuario(usuario);
        }

    }
}
