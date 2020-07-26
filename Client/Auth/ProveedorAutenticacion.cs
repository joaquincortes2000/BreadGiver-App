using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BreadGiverApp.Client.Auth
{
    public class ProveedorAutenticacion : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var Visitante = new ClaimsIdentity(new List<Claim>()
            {
                new Claim("Clave", "Valor"),
                new Claim(ClaimTypes.Name, "nombre"),
                new Claim(ClaimTypes.Role, "visitante"),
            }, "prueba");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(Visitante)));
        }
    }
}
