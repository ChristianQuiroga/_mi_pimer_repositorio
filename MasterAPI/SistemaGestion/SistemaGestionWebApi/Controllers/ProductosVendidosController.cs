using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosVendidosController : ControllerBase
    {
        [HttpGet(Name = "ListarProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos().ToArray();
        }


        //Post - Insertar
        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido); //va sin el return porque es Void.
        }


        //Put - Modificar
        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)  //los parámetros van en el Body
        {
            ProductoVendidoBussiness.ModificarProductoVendido(productoVendido);
        }

        //Delete
        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] ProductoVendido productoVendido)  //los parámetros van en el Body
        {
            ProductoVendidoBussiness.EliminarProductoVendido(productoVendido);
            
        }
    }
}
