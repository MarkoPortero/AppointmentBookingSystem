#pragma checksum "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "039dcb238bc049770e9683c2fd8c9f1834622648"
// <auto-generated/>
#pragma warning disable 1591
namespace AppointmentBookingSystem.Pages.AppointmentData
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
#line 2 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
           [Authorize(Roles = "Medical Practitioner")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AppointmentData/AppointmentHistory")]
    public partial class AppointmentHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
 if (Patients is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading Patients...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                     _appointment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.AddMarkupContent(7, "<h1>AppointmentHistory</h1>\r\n        ");
                __builder2.AddMarkupContent(8, "<h3>Please select a patient:</h3>\r\n        ");
                __Blazor.AppointmentBookingSystem.Pages.AppointmentData.AppointmentHistory.TypeInference.CreateInputSelect_0(__builder2, 9, 10, "PatientId", 11, 
#nullable restore
#line 17 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                                 SelectedPatient

#line default
#line hidden
#nullable disable
                , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedPatient = __value, SelectedPatient)), 13, () => SelectedPatient, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.AddMarkupContent(16, "<option>Patient</option>\r\n");
#nullable restore
#line 19 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
             foreach (var patient in Patients)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(17, "                ");
                    __builder3.OpenElement(18, "option");
                    __builder3.AddContent(19, 
#nullable restore
#line 21 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                         patient.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(20, " ");
                    __builder3.AddContent(21, 
#nullable restore
#line 21 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                     patient.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(22, " ");
                    __builder3.AddContent(23, 
#nullable restore
#line 21 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                                        patient.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n");
#nullable restore
#line 22 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(25, "        ");
                }
                );
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn-primary");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                              () => GetAppointmentHistory()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(30, "Get history");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 26 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
     if (PatientSelected)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "        ");
            __builder.OpenElement(34, "table");
            __builder.AddAttribute(35, "class", "table table-striped");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.AddMarkupContent(37, @"<thead>
                <tr>
                    <th>Appointment Id</th>
                    <th>Patient Id</th>
                    <th>Staff Id</th>
                    <th>Appointment DateTime</th>
                    <th>Appointment Duration</th>
                    <th>Patient Name</th>
                </tr>
            </thead>
            ");
            __builder.OpenElement(38, "tbody");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 40 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                 foreach (AppointmentModel appointment in _appointments)
                {
                    if (appointment.PatientId == PatientId)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 45 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                 appointment.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 46 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                 appointment.PatientId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 47 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                 appointment.AppointmentDateTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 48 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                 appointment.AppointmentDuration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 49 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                 appointment.PatientFirstname

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, " ");
            __builder.AddContent(58, 
#nullable restore
#line 49 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                                               appointment.PatientLastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                            ");
            __builder.OpenElement(60, "td");
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn-primary");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                                                                      () => ViewNotes(appointment.Id, PatientId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "View Notes");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 55 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 59 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentHistory.razor"
       
    private AppointmentModel _appointment = new AppointmentModel();
    private List<AppointmentModel> _appointments;
    private List<PatientModel> Patients { get; set; }
    private string SelectedPatient { get; set; }
    private bool PatientSelected { get; set; } = false;
    private int PatientId { get; set; }
    private int StaffId;

    protected override async Task OnInitializedAsync()
    {
        Patients = await PatientDatabase.GetAllPatients();
        var id = await SessionStorage.GetItemAsync<string>("userId");
        StaffId = int.Parse(id);
        _appointments = await AppointmentDatabase.GetAllAppointmentsForStaffMemberFromCredentials(StaffId);
    }

    private void GetAppointmentHistory()
    {
        if (SelectedPatient is null)
        {
            return;
        }
        string[] patientDetails = SelectedPatient.Split(' ');
        PatientId = int.Parse(patientDetails[0]);
        PatientSelected = true;
    }

    private void ViewNotes(int appointmentId, int patientId)
    {
        NavigationManager.NavigateTo($"/PatientNotes/{appointmentId}/{patientId}/{StaffId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAppointmentData AppointmentDatabase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPatientData PatientDatabase { get; set; }
    }
}
namespace __Blazor.AppointmentBookingSystem.Pages.AppointmentData.AppointmentHistory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
