#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b5cde1721a221b42dddcfb63b9c7fc494b4780"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiverApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using BreadGiverApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Repositorios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center font-weight-bold\">Bienvenido a BreadGiver</h1>\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"font-weight-bold text-center\">Nuestros productos</h3>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-columns");
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
     foreach (var item in todoItems ?? new List<Producto>())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col mb-4 shadow");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenComponent<BreadGiverApp.Client.Shared.CardProduct>(9);
            __builder.AddAttribute(10, "Imagen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
                                  item.ImagenProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Nombre", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
                                                                item.NombreProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Precio", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
                                                                                              item.PrecioProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Cantidad", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
                                                                                                                              item.CantidadProducto

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 18 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Index.razor"
 



    private List<Producto> todoItems;

    protected override async Task OnInitializedAsync() =>
    todoItems = await Http.GetFromJsonAsync<List<Producto>>("producto/obtenerTodos");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
