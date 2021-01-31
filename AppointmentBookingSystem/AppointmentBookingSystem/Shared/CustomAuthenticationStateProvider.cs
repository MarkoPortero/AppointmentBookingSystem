namespace AppointmentBookingSystem
{
    using Blazored.SessionStorage;
    using Microsoft.AspNetCore.Components.Authorization;
    using System.Threading.Tasks;
    using System.Security.Claims;

    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;

        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // saves the login status when page is refreshed
            var id = await _sessionStorageService.GetItemAsync<string>("userId");
            var userName = await _sessionStorageService.GetItemAsync<string>("userName");
            var role = await _sessionStorageService.GetItemAsync<string>("role");
            ClaimsIdentity identity;
            if (userName != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, id),
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, role), 
                }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void AuthenticateUser(int id, string userName, string role)
        {
            var identity = new ClaimsIdentity(new []
            {
                new Claim(ClaimTypes.NameIdentifier, id.ToString()), 
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, role), 
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void LogoutUser()
        {
            _sessionStorageService.RemoveItemAsync("role");
            _sessionStorageService.RemoveItemAsync("userName");
            _sessionStorageService.RemoveItemAsync("userId");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
