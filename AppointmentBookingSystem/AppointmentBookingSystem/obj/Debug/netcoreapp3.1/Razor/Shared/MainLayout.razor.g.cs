#pragma checksum "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c5d39bf49c888f9a83322fbc507a7d1bf75f37"
// <auto-generated/>
#pragma warning disable 1591
namespace AppointmentBookingSystem.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystemDAL.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystemDAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using AppointmentBookingSystemDAL.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\_Imports.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<AppointmentBookingSystem.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "button");
                __builder2.AddAttribute(16, "class", "btn btn-link");
                __builder2.AddAttribute(17, "id", "logout");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\MainLayout.razor"
                                                                   Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Logout");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
            }
            ));
            __builder.AddAttribute(21, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.AddMarkupContent(23, "<a href=\"/login\">Login</a>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "content px-4");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddContent(29, 
#nullable restore
#line 22 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\MainLayout.razor"
 
    public void Logout()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).LogoutUser();
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
