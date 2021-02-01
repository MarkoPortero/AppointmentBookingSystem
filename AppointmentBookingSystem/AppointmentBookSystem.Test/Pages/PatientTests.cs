using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AppointmentBookingSystem.Pages.PatientData;
using AppointmentBookingSystemDAL.DataAccess.Interfaces;
using AppointmentBookingSystemDAL.Models;
using Bunit;
using Bunit.Extensions;
using Bunit.TestDoubles;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using TestContext = Bunit.TestContext;

namespace AppointmentBookSystem.Test.Pages
{
    public class PatientTests : TestContext
    {
        TestContext ctx = new TestContext();
        Mock<NavigationManager> navigationManager = new Mock<NavigationManager>();
        Mock<IJSRuntime> ijsRuntime = new Mock<IJSRuntime>();
        [SetUp]
        public void Setup()
        {
            ctx.AddTestAuthorization().SetAuthorized("Test")
                .SetRoles("Medical Practitioner").SetClaims(new Claim (ClaimTypes.Role, "Admin"));

            var patientRepo = new Mock<IPatientData>();
            patientRepo.Setup(x => x.GetAllPatients()).Returns(Task.FromResult(new List<PatientModel>
            {
                new PatientModel()
                {
                    FirstName = "TestFirstName",
                    LastName = "TestLastName",
                    Address = "TestAddress",
                    ContactNumber = "12345678",
                    DateOfBirth = DateTime.UtcNow,
                    Email = "test@test.com",
                    Id = 1
                }
            }));
            var mockLogger = new Mock<ILogger<Patient>>();
            ctx.Services.AddSingleton<ILogger<Patient>>(mockLogger.Object);
            ctx.Services.AddSingleton<IPatientData>(patientRepo.Object);
            ctx.Services.AddSingleton<NavigationManager>(navigationManager.Object);
            ctx.Services.AddSingleton<IJSRuntime>(ijsRuntime.Object);
        }

        [Test]
        public void PatientsAdd_RenderingAsAdmin_RendersCorrectly()
        {
            var cut = ctx.RenderComponent<Patient>();
            cut.Find("h1").MarkupMatches("<h1>Patient</h1>");
            Assert.That(cut.Markup.Contains("TestFirstName"), Is.True);
            Assert.That(cut.Markup.Contains("TestLastName"), Is.True);
            Assert.That(cut.Markup.Contains("TestAddress"), Is.True);
            Assert.That(cut.Markup.Contains("12345678"), Is.True);
            Assert.That(cut.Markup.Contains("test@test.com"), Is.True);
        }


    }
}
