#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f148b8b80f8011a178bb8436eff352d2a0f92b"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiverApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using BreadGiverApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\_Imports.razor"
using BreadGiverApp.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center font-weight-bold\">Bienvenido a BreadGiver</h1>\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3 class=\"font-weight-bold\">Productos mas vendidos</h3>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-group");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 10 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Index.razor"
     for (int i = 0; i < 4; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenComponent<BreadGiverApp.Client.Shared.CardProduct>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n<hr>\r\n");
            __builder.AddMarkupContent(9, "<h3 class=\"font-weight-bold\">Productos con descuentos</h3>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-group");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 18 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Index.razor"
     for (int i = 0; i < 4; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "        ");
            __builder.OpenComponent<BreadGiverApp.Client.Shared.CardProduct>(14);
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 21 "C:\Users\joaqu\Documents\GitHub\BreadGiverApp\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
