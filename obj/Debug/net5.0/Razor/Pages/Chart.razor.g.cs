#pragma checksum "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\Pages\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deadbd9ecf94bc0e710e0e059dfe60ca4d170a12"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAssemblyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chartdata")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\Pages\Chart.razor"
                                          ButtonClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Create Chart");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<div id=\"BarCharts\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projects\Learning\Blazor\BlazorWebAssemblyApp\Pages\Chart.razor"
       

[Inject]
IJSRuntime JSRuntime { get; set; }

   private async Task ButtonClicked()
   {       
       await JSRuntime.InvokeVoidAsync("CreateCharts");
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
