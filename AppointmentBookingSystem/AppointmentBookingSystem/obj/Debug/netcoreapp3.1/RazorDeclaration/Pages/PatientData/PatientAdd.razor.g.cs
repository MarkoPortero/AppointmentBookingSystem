// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 5 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\PatientAdd.razor"
           [Authorize(Roles = "Administrator, Receptionist")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PatientData/PatientAdd")]
    public partial class PatientAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\PatientData\PatientAdd.razor"
       
    private PatientAddModel _patientAddModel = new PatientAddModel();

    private async Task InsertPatient()
    {
        PatientModel patient = new PatientModel()
        {
            FirstName = _patientAddModel.FirstName,
            LastName = _patientAddModel.LastName,
            Address = _patientAddModel.Address,
            ContactNumber = _patientAddModel.ContactNumber,
            Email = _patientAddModel.Email,
            DateOfBirth = _patientAddModel.DateOfBirth.Date
        };

        await Database.InsertPatient(patient);
        //wipe out patient model
        _patientAddModel = new PatientAddModel();
        BackToPatient();
    }

    private void BackToPatient()
    {
        NavigationManager.NavigateTo("/Patients");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPatientData Database { get; set; }
    }
}
#pragma warning restore 1591
