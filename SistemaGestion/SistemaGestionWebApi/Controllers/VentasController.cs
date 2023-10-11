using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        //Get
        [HttpGet(Name = "ListarVenta")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVentas().ToArray();

        }

        //Post - Insertar
        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)  //los parámetros van en el Body
        {
            VentaBussiness.CrearVenta(venta);
        }


        //Put - Modificar
        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)  //los parámetros van en el Body
        {
            VentaBussiness.ModificarVenta(venta);
        }

        //Delete
        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] Venta venta)  //los parámetros van en el Body
        {
            VentaBussiness.EliminarVenta(venta);
        }
    }
}
