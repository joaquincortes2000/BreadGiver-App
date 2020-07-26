namespace BreadGiverApp.Shared
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string ValorTotal { get; set; }
        public string IVA { get; set; }
        public string CantidadTotal { get; set; }
        public Usuario UsuarioCotizacion { get; set; }
    }
}
