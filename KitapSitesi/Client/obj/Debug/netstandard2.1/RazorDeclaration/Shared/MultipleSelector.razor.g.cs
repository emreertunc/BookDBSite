#pragma checksum "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd039cc45233e87b4f4fe96a45bffc638b405a1f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\MultipleSelector.razor"
       
    private string removeAllText = "";
    [Parameter]
    public List<MultipleSelectorModel> NoSelected { get; set; } = new List<MultipleSelectorModel>();
    [Parameter]
    public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();

    private void Select(MultipleSelectorModel item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
    }

    private void HepsiniSec()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
    }

    private void SecimiTemizle()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
