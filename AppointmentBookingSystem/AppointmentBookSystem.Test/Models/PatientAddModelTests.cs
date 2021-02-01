namespace AppointmentBookSystem.Test
{
    using AppointmentBookingSystem.Models;
    using NUnit.Framework;
    using System;
    using System.Linq;

    public class PatientAddModelTests :  ViewModelTestBase
    {
        [Test]
        public void PatientAddModel_ValidModel_PassesValidation()
        {
            var test = new PatientAddModel()
            {
                FirstName = "Mark",
                LastName = "Porter",
                Email = "mark@porter.com",
                Address = "1 Foyle",
                ContactNumber = "08765644323",
                DateOfBirth = DateTime.UtcNow
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Any()), Is.False);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Any()), Is.False);
        }

        [Test]
        public void PatientAddModel_FirstNameStringContainingNumbers_FailsValidation()
        {
            var test = new PatientAddModel
            {
                FirstName = "123"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Must be only letters, unless your father is elon musk")), Is.True);
        }

        [Test]
        public void PatientAddModel_FirstNameStringTooShort_FailsValidation()
        {
            var test = new PatientAddModel
            {
                FirstName = "x"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("First name is too short.")));
        }

        [Test]
        public void PatientAddModel_FirstNameStringTooLong_FailsValidation()
        {
            var test = new PatientAddModel
            {
                FirstName = "ThisIsOneVeryLongName"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("First Name is too long.")));
        }

        [Test]
        public void PatientAddModel_FirstNameNotSupplied_FailsValidation()
        {
            var test = new PatientAddModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }


        [Test]
        public void PatientAddModel_LastNameStringContainingNumbers_FailsValidation()
        {
            var test = new PatientAddModel
            {
                LastName = "123"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Must be only letters, unless your father is elon musk")), Is.True);
        }

        [Test]
        public void PatientAddModel_LastNameStringTooShort_FailsValidation()
        {
            var test = new PatientAddModel
            {
                LastName = "x"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Last name is too short.")), Is.True);
        }

        [Test]
        public void PatientAddModel_LastNameStringTooLong_FailsValidation()
        {
            var test = new PatientAddModel
            {
                LastName = "ThisIsOneVeryLongName"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Last Name is too long.")));
        }

        [Test]
        public void PatientAddModel_LastNameNotSupplied_FailsValidation()
        {
            var test = new PatientAddModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")));
        }

        [Test]
        public void PatientAddModel_AddressStringTooShort_FailsValidation()
        {
            var test = new PatientAddModel
            {
                Address = "x"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Address")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Address is too short.")), Is.True);
        }

        [Test]
        public void PatientAddModel_AddressNotSupplied_FailsValidation()
        {
            var test = new PatientAddModel();
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Address")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")));
        }

        [Test]
        public void PatientAddModel_ContactNumberNotNumbers_FailsValidation()
        {
            var test = new PatientAddModel
            {
                ContactNumber = "abcdefgh"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("ContactNumber")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Contact number must be numeric")));
        }

        [Test]
        public void PatientAddModel_ContactNumberTooShort_FailsValidation()
        {
            var test = new PatientAddModel
            {
                ContactNumber = "123"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("ContactNumber")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Phone Number not long enough")));
        }

        [Test]
        public void PatientAddModel_ContactNumberTooLong_FailsValidation()
        {
            var test = new PatientAddModel
            {
                ContactNumber = "123456789101112131415"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("ContactNumber")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Phone Number is too long")));
        }

        [Test]
        public void PatientAddModel_ContactNumberNotSupplied_FailsValidation()
        {
            var test = new PatientAddModel();
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("ContactNumber")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")));
        }

        [Test]
        public void PatientAddModel_EmailTooShort_FailsValidation()
        {
            var test = new PatientAddModel
            {
                Email = "a@b"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Email")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Email not long enough")));
        }

        [Test]
        public void PatientAddModel_EmailInvalid_FailsValidation()
        {
            var test = new PatientAddModel
            {
                Email = "TOTALLY LEGIT EMAIL ADDRESS"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Email")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Email is invalid")));
        }

        [Test]
        public void PatientAddModel_EmailNotSupplied_FailsValidation()
        {
            var test = new PatientAddModel();
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Email")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")));
        }
    }


}