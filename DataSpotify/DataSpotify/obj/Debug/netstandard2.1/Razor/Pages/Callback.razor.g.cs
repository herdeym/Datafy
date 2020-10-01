#pragma checksum "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Callback.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2d58308d7de70d57aa1a32858dcd01af376501"
// <auto-generated/>
#pragma warning disable 1591
namespace DataSpotify.Pages
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
#nullable restore
#line 3 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Callback.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Callback.razor"
using SpotifyAPI.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/callback")]
    public partial class Callback : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 12 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Callback.razor"
    _loginMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Callback.razor"
       

    string _loginMessage = "Logging in...";

    protected override async Task OnInitializedAsync()
    {
        if (ah.SetLinkParams(UriHelper.Uri))
        {
            await api.Authenticate(ah.AccessToken, ah.TokenType);


            if (api.IsAuthenticated())
            {
                _loginMessage = "Logged in!";
                // Without this check, navigating to playlists can cause a NullReferenceException
                await localStorage.SetItemAsync("AccessToken", ah.AccessToken);
                await localStorage.SetItemAsync("TokenType", ah.TokenType);
                await localStorage.SetItemAsync("expiresIn", ah.ExpiresIn);
                DateTime loggedIn = DateTime.Now;
                await localStorage.SetItemAsync("loggedIn", loggedIn);
                UriHelper.NavigateTo("home");
            }

        }
        else
        {
            _loginMessage = "Login Failed...";
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private API api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Auth ah { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591