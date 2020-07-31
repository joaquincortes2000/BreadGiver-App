using System.ComponentModel.DataAnnotations;

namespace BreadGiverApp.Shared
{
    public class Producto
    {
        public int Id { get; set; }
        
        [Required]
        [Range(typeof(string), "true", "true",
        ErrorMessage = "El nombre debe ser solo texto")]
        public string NombreProducto { get; set; }
        
        [Range(1, 100000000, ErrorMessage = "El precio no debe ser menor a 0.")]
        public string PrecioProducto { get; set; }

        [Range(1, 100000000, ErrorMessage = "La cantidad de stock no puede ser menor a 0.")]
        public int CantidadProducto { get; set; }
        
        
        public string ImagenProducto { get; set; }

    }
}
