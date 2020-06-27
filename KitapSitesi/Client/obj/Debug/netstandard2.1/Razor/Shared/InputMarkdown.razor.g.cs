#pragma checksum "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99bec62963283823d09cc38b88e62602b3f7b73c"
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
#nullable restore
#line 2 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor"
using System.Linq.Expressions;

#line default
#line hidden
#nullable disable
    public partial class InputMarkdown<TValue> : InputTextArea
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(7);
            __builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor"
                                    CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentValue = __value, CurrentValue))));
            __builder.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentValue));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n        ");
            __Blazor.KitapSitesi.Client.Shared.InputMarkdown.TypeInference.CreateValidationMessage_0(__builder, 12, 13, 
#nullable restore
#line 9 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor"
                                For

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Emre\source\repos\RN-KitapSite\KitapSitesi\Client\Shared\InputMarkdown.razor"
       
    [Parameter] public Expression<Func<TValue>> For { get; set; }
    [Parameter] public string Label { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.KitapSitesi.Client.Shared.InputMarkdown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
