#pragma checksum "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacb77e268ad04ee475bae1cbd7fb13141b5f5e6"
// <auto-generated/>
#pragma warning disable 1591
namespace KitapSitesi.Client.Pages.Kisiler
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using KitapSitesi.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using KitapSitesi.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using ClientClassLibrary.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using OrtakClassLibrary.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using ClientClassLibrary.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using OrtakClassLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\_Imports.razor"
using ClientClassLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/kisi/edit/{KisiId:int}")]
    public partial class EditKisi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Kişiyi Bilgilerini Düzenle</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor"
 if (Kisi != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<KitapSitesi.Client.Pages.Kisiler.KisiForm>(2);
            __builder.AddAttribute(3, "Kisi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OrtakClassLibrary.Entities.Kisi>(
#nullable restore
#line 9 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor"
                    Kisi

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor"
                                         Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Pages\Kisiler\EditKisi.razor"
       
    [Parameter] public int KisiId { get; set; }

    Kisi Kisi;

    protected async override Task OnInitializedAsync()
    {
        Kisi = await kisiRepository.GetKisiById(KisiId);
    }

    private async Task Edit()
    {
        await kisiRepository.UpdateKisi(Kisi);
        navigationManager.NavigateTo("kisiler");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IKisiRepository kisiRepository { get; set; }
    }
}
#pragma warning restore 1591