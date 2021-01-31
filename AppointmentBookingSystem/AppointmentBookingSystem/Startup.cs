namespace AppointmentBookingSystem
{
    using Blazored.SessionStorage;
    using Microsoft.AspNetCore.Components.Authorization;
    using AppointmentBookingSystemDAL;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using AppointmentBookingSystemDAL.DataAccess;
    using AppointmentBookingSystemDAL.DataAccess.Interfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime, adds services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddBlazoredSessionStorage();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IPatientData, PatientData>();
            services.AddTransient<IStaffData, StaffData>();
            services.AddTransient<IUserCredentialsData, UserCredentialsData>();
            services.AddTransient<IUserRoleData, UserRoleData>();
            services.AddTransient<IAppointmentData, AppointmentData>();
            services.AddTransient<IPatientNotesData, PatientNotesData>();
        }

        // This method gets called by the runtime - configures the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
