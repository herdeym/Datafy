#pragma checksum "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b510241f66e4dace6118fd448b835a3599662e"
// <auto-generated/>
#pragma warning disable 1591
namespace DataSpotify.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using DataSpotify;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using DataSpotify.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\_Imports.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
    public partial class ErrorBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor"
 if (!string.IsNullOrEmpty(_errorText))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-danger alert-dismissible");
            __builder.AddAttribute(3, "style", "position: fixed; bottom: 1em; width: auto; right: 2em;");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "close");
            __builder.AddAttribute(8, "data-dismiss", "alert");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor"
                                                                           ClearError

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "mb-0");
            __builder.AddContent(14, 
#nullable restore
#line 6 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor"
                         _errorText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 8 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Shared\ErrorBar.razor"
       
    static string _errorText = "";

    public static string AddError(string text)
    {
        _errorText += text;
        return _errorText;
    }

    public static void ClearError()
    {
        _errorText = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
