#pragma checksum "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3607a172e648092eba440a11bb31ff6976696c35"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>AppointmentBookingSystem</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(10);
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", 
#nullable restore
#line 8 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "ul");
                __builder2.AddAttribute(18, "class", "nav flex-column");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "li");
                __builder2.AddAttribute(21, "class", "nav-item px-3");
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
                __builder2.AddAttribute(24, "class", "nav-link");
                __builder2.AddAttribute(25, "href", "");
                __builder2.AddAttribute(26, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(28, "\r\n                    <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(31);
                __builder2.AddAttribute(32, "Roles", "Administrator");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((staff) => (__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                ");
                    __builder3.OpenElement(35, "li");
                    __builder3.AddAttribute(36, "class", "nav-item px-3");
                    __builder3.AddMarkupContent(37, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
                    __builder3.AddAttribute(39, "class", "nav-link");
                    __builder3.AddAttribute(40, "href", "Staff");
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(42, "\r\n                        <span class=\"oi oi-person\" aria-hidden=\"true\"></span> Staff\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(46);
                __builder2.AddAttribute(47, "Roles", "Administrator, Receptionist");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((patients) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                ");
                    __builder3.OpenElement(50, "li");
                    __builder3.AddAttribute(51, "class", "nav-item px-3");
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
                    __builder3.AddAttribute(54, "class", "nav-link");
                    __builder3.AddAttribute(55, "href", "Patients");
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(57, "\r\n                        <span class=\"oi oi-people\" aria-hidden=\"true\"></span> Patients\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(61);
                __builder2.AddAttribute(62, "Roles", "Administrator, Receiptionist, Medical Practitioner");
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((appointments) => (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n                ");
                    __builder3.OpenElement(65, "li");
                    __builder3.AddAttribute(66, "class", "nav-item px-3");
                    __builder3.AddMarkupContent(67, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
                    __builder3.AddAttribute(69, "class", "nav-link");
                    __builder3.AddAttribute(70, "href", "Appointments");
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(72, "\r\n                        <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Appointments\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(76);
                __builder2.AddAttribute(77, "Roles", "Medical Practitioner");
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((patientNotes) => (__builder3) => {
                    __builder3.AddMarkupContent(79, "\r\n                ");
                    __builder3.OpenElement(80, "li");
                    __builder3.AddAttribute(81, "class", "nav-item px-3");
                    __builder3.AddMarkupContent(82, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(83);
                    __builder3.AddAttribute(84, "class", "nav-link");
                    __builder3.AddAttribute(85, "href", "/AppointmentData/AppointmentHistory");
                    __builder3.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(87, "\r\n                        <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Appointment History\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n                ");
                    __builder3.OpenElement(90, "li");
                    __builder3.AddAttribute(91, "class", "nav-item px-3");
                    __builder3.AddMarkupContent(92, "\r\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(93);
                    __builder3.AddAttribute(94, "class", "nav-link");
                    __builder3.AddAttribute(95, "href", "patientNotes");
                    __builder3.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(97, "\r\n                        <span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Patient Notes\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(99, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Shared\NavMenu.razor"
       
    private bool _collapseNavMenu = true;

    private string NavMenuCssClass => _collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        _collapseNavMenu = !_collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
