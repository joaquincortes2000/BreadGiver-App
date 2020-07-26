using System;
using System.Collections.Generic;
using System.Text;

namespace BreadGiverApp.Shared
{
    public class Cotizacion_has_Producto
    {
        public int id { get; set; }
        public Cotizacion cotizacionId { get; set; }
        public Producto productoId { get; set; }
    }
}
