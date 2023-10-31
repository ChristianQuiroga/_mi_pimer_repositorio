using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities.Responses
{
    public class UsuarioResponse
    {
        
        public List<Usuario> Usuarios { get; set; } 
        public Usuario Usuario { get; set; }
        public string Mensaje { get; set; }
        public Exception Error {  get; set; }

    }
}
