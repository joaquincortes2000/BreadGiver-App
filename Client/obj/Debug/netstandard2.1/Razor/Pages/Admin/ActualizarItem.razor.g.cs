#pragma checksum "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e93261ea03ccf05c3135c7cc702dcf58c01931"
// <auto-generated/>
#pragma warning disable 1591
namespace BreadGiverApp.Client.Pages.Admin
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/actualizarItem/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/actualizarItem")]
    public partial class ActualizarItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">ActualizarItem</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"col\">\r\n\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                          producto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<p class=\"text-center\">Producto</p>\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "hidden");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                                   producto.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.Id = __value, producto.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "placeholder", "Ingresa el producto");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                                                                                           producto.NombreProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.NombreProducto = __value, producto.NombreProducto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.AddMarkupContent(33, "<p class=\"text-center\">Imagen referencial</p>\r\n                ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "placeholder", "Ingresa el link de la imagen");
                __builder2.AddAttribute(38, "required", true);
                __builder2.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                                                                                                    producto.ImagenProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.ImagenProducto = __value, producto.ImagenProducto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.AddMarkupContent(46, "<p class=\"text-center\">Precio por unidad</p>\r\n                ");
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "placeholder", "Ingresa el precio unitario");
                __builder2.AddAttribute(51, "required", true);
                __builder2.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                                                                                                  producto.PrecioProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.PrecioProducto = __value, producto.PrecioProducto));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.AddMarkupContent(59, "<p class=\"text-center\">Total de productos</p>\r\n                ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "type", "number");
                __builder2.AddAttribute(63, "placeholder", "Ingresa la cantidad total");
                __builder2.AddAttribute(64, "required", true);
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                                                                                                   producto.CantidadProducto

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.CantidadProducto = __value, producto.CantidadProducto, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "type", "submit");
                __builder2.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
                                            SaveItem

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "class", "btn btn-primary w-100");
                __builder2.AddContent(73, "Actualizar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(75, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.AddMarkupContent(77, "<div class=\"col\">\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\joaqu\Documents\GitHub\BreadGiver-app\Client\Pages\Admin\ActualizarItem.razor"
       
        [Parameter]
        public int Id { get; set; }

    private List<Producto> todoItems;

    protected override async Task OnInitializedAsync() =>
    todoItems = await Http.GetFromJsonAsync<List<Producto>>("producto/obtenerTodos");

    private Producto producto = new Producto();

    private void EditarProducto(int Id)
    {
        producto = todoItems.Single(i => i.Id == Id);

    }
    private async Task SaveItem() => await Http.PutAsJsonAsync($"producto/obtenerTodos/{producto.Id}", producto);




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
