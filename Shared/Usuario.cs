using System;
using System.Collections.Generic;
using System.Text;

namespace BreadGiverApp.Shared
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string NumeroUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public string RutUsuario { get; set; }
        //public Rol RolUsuario { get; set; }
        //public CarroCompra CarroUsuario { get; set; }
    }
}
