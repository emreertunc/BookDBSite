#pragma checksum "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e5fba236bb09360a28c8db064f5a11a0cd9862"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KitapSitesi.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\_Imports.razor"
using KitapSitesi.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Emre\source\repos\KitapSite\BlazorMovies\Client\Pages\Index.razor"
      
    private List<Movie> InTheaters;
    private List<Movie> UpcomingReleases;
    protected async override Task OnInitializedAsync()
    {
        var response = await moviesRepository.GetIndexPageDTO();
        InTheaters = response.Intheaters;
        UpcomingReleases = response.UpcomingReleases;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
