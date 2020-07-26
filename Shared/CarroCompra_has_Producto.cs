using System;
using System.Collections.Generic;
using System.Text;

namespace BreadGiverApp.Shared
{
    public class CarroCompra_has_Producto
    {
        public int id { get; set; }
        public CarroCompra carroCompraId { get; set; }
        public Producto productoId { get; set; }
    }
}
