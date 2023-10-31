using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        //GET
        [HttpGet(Name = "ListarProductos")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.ListarProductos().ToArray();

        }

        //Post - Insertar
        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)  //los parámetros van en el Body
        {
            ProductoBussiness.CrearProducto(producto);
        }


        //Put - Modificar
        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)  //los parámetros van en el Body
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        //Delete
        [HttpDelete(Name = "EliminarProducto")]
        //public void Delete([FromBody] Producto producto)  //los parámetros van en el Body
        public void Delete([FromBody] int Id)
        {
            ProductoBussiness.EliminarProducto(Id);
        }
        


    }
}
