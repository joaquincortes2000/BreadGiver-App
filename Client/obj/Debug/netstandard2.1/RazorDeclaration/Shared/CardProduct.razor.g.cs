#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Shared\CardProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acef3bd310a436dc595c030084e3cafbb40e064d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BreadGiverApp.Client.Shared
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
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\_Imports.razor"
using Repositorios;

#line default
#line hidden
#nullable disable
    public partial class CardProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Shared\CardProduct.razor"
               
            [Parameter]
            public string Nombre { get; set; }
            [Parameter]
            public string Precio { get; set; }
            [Parameter]
            public int Cantidad { get; set; }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
