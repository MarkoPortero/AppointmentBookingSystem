// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 9 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentAdd.razor"
           [Authorize(Roles = "Administrator, Receptionist")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AppointmentData/AppointmentAdd")]
    public partial class AppointmentAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\MarkP\source\repos\AppointmentBookingSystem\AppointmentBookingSystem\Pages\AppointmentData\AppointmentAdd.razor"
       
    AppointmentModel _appointmentModel = new AppointmentModel();
    private List<StaffModel> StaffMembers { get; set; }
    private List<PatientModel> Patients { get; set; }
    private List<AppointmentModel> Appointments { get; set; }
    private string SelectedPatient { get; set; }
    private string StaffMember { get; set; }
    private string Duration { get; set; } = "15";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            StaffMembers = await StaffDatabase.GetAllStaff();
            Patients = await PatientDatabase.GetAllPatients();
            Appointments = await AppointmentDatabase.GetAllAppointments();
        }
        catch(SqlException ex)
        {
            Logger.LogError("Error loading information from server", ex);
        }
    }

    private void BackToAppointments()
    {
        NavigationManager.NavigateTo("/Appointments");
    }

    private async Task InsertAppointment()
    {
        if (StaffMember is null)
        {
            await JsRuntime.InvokeVoidAsync("alert", $"Please select a valid Staff Member");
            return;
        }
        if (SelectedPatient is null)
        {
            await JsRuntime.InvokeVoidAsync("alert", $"Please select a valid Patient");
            return;
        }
        string[] staffDetails = StaffMember.Split(' ');
        string[] patientDetails = SelectedPatient.Split(' ');

        if (!int.TryParse(patientDetails[0], out int patientId))
        {
            await JsRuntime.InvokeVoidAsync("alert", $"Please select a valid Patient");
            return;
        }
        if (!int.TryParse(staffDetails[0], out int staffId))
        {
            await JsRuntime.InvokeVoidAsync("alert", $"Please select a valid Staff Member");
            return;
        }

        if (_appointmentModel.AppointmentDateTime < DateTime.Now)
        {
            await JsRuntime.InvokeVoidAsync("alert", $"Appointment cannot be made in the past");
            return;
        }

        _appointmentModel.PatientId = patientId;
        _appointmentModel.StaffId = staffId;
        _appointmentModel.AppointmentDuration = int.Parse(Duration);

        if (Appointments != null)
        {
            var currentAppointments = Appointments.Where(x => x.StaffId == staffId || x.PatientId == patientId);
            var scheduledAppointmentEndTime = _appointmentModel.AppointmentDateTime.AddMinutes(_appointmentModel.AppointmentDuration);

            foreach (var appointment in currentAppointments)
            {
                var endTime = appointment.AppointmentDateTime.AddMinutes(appointment.AppointmentDuration);
                var isStartDateTimeInvalid = DateTimeRangeCheck(_appointmentModel.AppointmentDateTime, appointment.AppointmentDateTime, endTime);
                var isAppointmentDurationInvalid = DateTimeRangeCheck(scheduledAppointmentEndTime, appointment.AppointmentDateTime, endTime);

                if (isStartDateTimeInvalid || isAppointmentDurationInvalid)
                {
                    await JsRuntime.InvokeVoidAsync("alert", $"This appointment conflicts with another appointment.");
                    return;
                }
            }
        }
        try
        {
            Logger.LogInformation("Inserting Appointment ", _appointmentModel);
            await AppointmentDatabase.InsertAppointment(_appointmentModel);
        }
        catch (SqlException ex)
        {
            Logger.LogError("Error writing to database", ex);
        }
        BackToAppointments();
    }

    private bool DateTimeRangeCheck(DateTime proposedAppointment, DateTime startTime, DateTime endTime)
    {
        return proposedAppointment >= startTime && proposedAppointment < endTime;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<AppointmentAdd> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAppointmentData AppointmentDatabase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPatientData PatientDatabase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStaffData StaffDatabase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
