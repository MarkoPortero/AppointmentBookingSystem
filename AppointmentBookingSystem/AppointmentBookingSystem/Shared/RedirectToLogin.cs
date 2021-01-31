namespace AppointmentBookingSystem.Shared
{
    using Microsoft.AspNetCore.Components;

    public class RedirectToLogin : ComponentBase
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("/Login");
        }
    }
}
