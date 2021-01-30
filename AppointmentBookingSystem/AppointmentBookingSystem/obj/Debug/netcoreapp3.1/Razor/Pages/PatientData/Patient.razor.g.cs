#pragma checksum "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "788e84386d2a11c810a0238174ce45339a40ef90"
// <auto-generated/>
#pragma warning disable 1591
namespace AppointmentBookingSystem.Pages.PatientData
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Patients")]
    public partial class Patient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Patient</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Insert new patient</h4>\r\n");
            __builder.AddMarkupContent(2, "<a class=\"btn btn-primary\" href=\"PatientData/PatientAdd\" role=\"button\">Add Patient</a>\r\n\r\n");
            __builder.AddMarkupContent(3, "<h4 class=\"p-3\">Current Patients</h4>\r\n");
#nullable restore
#line 12 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
 if (_patients is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>Loading Patients...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-striped");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, @"<thead>
        <tr>
            <th>Patient Id</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Address</th>
            <th>Contact Number</th>
            <th>Email Address</th>
            <th>Date of Birth</th>
        </tr>
        </thead>
        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 31 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
             foreach (PatientModel patient in _patients)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 34 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.ContactNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 39 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 40 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                         patient.DateOfBirth.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn-secondary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                                                                () => EditPatient(patient.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn-secondary");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
                                                                () => DeletePatient(patient)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 46 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 49 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\Patient.razor"
       
    private List<PatientModel> _patients;
    protected override async Task OnInitializedAsync()
    {
        _patients = await Database.GetAllPatients();
    }

    private async Task DeletePatient(PatientModel patient)
    {
        if(!await JsRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the patient '{patient.FirstName} {patient.LastName}'?"))
            return;
        await Database.DeletePatient(patient.Id);

        _patients.Remove(patient);
    }

    private void EditPatient(int patientId)
    {
        NavigationManager.NavigateTo($"/PatientData/PatientEdit/{patientId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPatientData Database { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
