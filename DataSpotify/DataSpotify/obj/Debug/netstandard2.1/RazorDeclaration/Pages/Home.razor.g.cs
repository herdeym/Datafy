#pragma checksum "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf44581d28326926045e4317ab8fdb52ecf474a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Home.razor"
using Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Home.razor"
using SpotifyAPI.Web.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "E:\BME\onlab\DS 3_2 másolata\DataSpotify\DataSpotify\Pages\Home.razor"
       
    string username = "";
    List<string> toptracktitles = new List<string>();
    Paging<FullTrack> toptracks;
    IEnumerable<FullTrack> tracks;
    string apiAuth = "";

    protected override async Task OnInitializedAsync()
    {
        if (!api.IsAuthenticated())
        {
            string at = await localStorage.GetItemAsync<string>("AccessToken");
            string tt = await localStorage.GetItemAsync<string>("TokenType");
            Console.WriteLine(at);
            Console.WriteLine(tt);
            await api.Authenticate(at, tt);
        }
        else
            Console.WriteLine("api hitelesítve");
        username = api.UserProfile.DisplayName;

        toptracks =  await API.S.GetUsersTopTracksAsync();
        tracks = toptracks.Items.ToList();
    }

    void trackClicked(FullTrack t)
    {
        nm.NavigateTo("track/" + t.Id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private API api { get; set; }
    }
}
#pragma warning restore 1591
