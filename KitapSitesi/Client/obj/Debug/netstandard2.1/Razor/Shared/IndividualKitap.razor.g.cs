#pragma checksum "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "858125a17ef14acd6b1953243d7d491e4686ef60"
// <auto-generated/>
#pragma warning disable 1591
namespace KitapSitesi.Client.Shared
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
    public partial class IndividualKitap : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "individual-kitap-container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 2 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
              kitapURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 3 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
                   kitapKapakURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "alt", "Kitap Kapağı");
            __builder.AddAttribute(9, "class", "kitap-kitapkapak");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "p");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "href", 
#nullable restore
#line 5 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
                 kitapURL

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 5 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
                            Kitap.TitleBrief

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "class", "btn btn-secondary");
            __builder.AddAttribute(21, "href", "/kitaplar/edit/" + (
#nullable restore
#line 7 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
                                                           Kitap.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "Düzenle");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
                            () => DeleteKitap.InvokeAsync(Kitap)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n            Sil\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\IndividualKitap.razor"
       
    [Parameter] public Kitap Kitap { get; set; }
    [Parameter] public EventCallback<Kitap> DeleteKitap { get; set; }
    private string kitapURL = string.Empty;
    private string kitapKapakURL = string.Empty;

    protected override void OnInitialized()
    {
        if (Kitap.KitapKapak != null)
        {
            kitapKapakURL = Kitap.KitapKapak;
        }
        else
        {
            kitapKapakURL = $"/images/ResimYok.png";
        }

        kitapURL = $"kitap/{Kitap.Id}/{Kitap.Baslik.Replace(" ", "-")}";

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591