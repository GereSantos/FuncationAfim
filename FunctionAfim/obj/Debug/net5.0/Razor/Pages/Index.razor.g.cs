#pragma checksum "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ee7073631b4b7699bad08a61c72c2ef4da02c9"
// <auto-generated/>
#pragma warning disable 1591
namespace FunctionAfim.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using FunctionAfim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\_Imports.razor"
using FunctionAfim.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cálculo da Função Afim</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<label>Coeficiente Angular</label>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "form-control");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
              cfa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cfa = __value, cfa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(7, "<label>Coeficiente Linear</label>\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
              cfl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cfl = __value, cfl));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n<br>\r\n\r\n\r\n");
            __builder.AddMarkupContent(13, "<label>Valor de X</label>\r\n");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
              x

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => x = __value, x));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(19, "label");
            __builder.AddContent(20, "Resultado: ");
#nullable restore
#line 18 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
__builder.AddContent(21, resultado);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<br>\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "text-center");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-outline-primary");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
                                                  CalcularAfim

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Calcular");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\geremias.bezerra\source\repos\FunctionAfim\FunctionAfim\Pages\Index.razor"
      
    int x;
    int cfa;
    int cfl;
    int resultado;

    void CalcularAfim()
    {
        resultado = (x) = (cfa * x) + cfl;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
