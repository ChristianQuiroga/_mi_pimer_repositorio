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
    public static class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }

        public static ProductoResponse CrearProducto(Producto producto)
        {
            return ProductoData.CrearProducto(producto);
        }

        public static ProductoResponse ModificarProducto(Producto producto)
        {
            return ProductoData.ModificarProducto(producto);
        }

        public static ProductoResponse EliminarProducto(int Id)
        { 
            return ProductoData.EliminarProducto(Id);
        }

        
    }
}
