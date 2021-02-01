namespace AppointmentBookSystem.Test
{
    using System.Linq;
    using AppointmentBookingSystem.Models;
    using NUnit.Framework;
    public class StaffViewModelTests : ViewModelTestBase
    {
        [Test]
        public void StaffViewModel_ValidModel_PassesValidation()
        {
            var test = new StaffViewModel()
            {
                FirstName = "Mark",
                LastName = "Porter",
                Address = "1 Foyle",
                Id = 1,
                UserName = "MarkPorter",
                Password = "Password123"

            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Any()), Is.False);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Any()), Is.False);
        }

        [Test]
        public void StaffViewModel_FirstNameStringContainingNumbers_FailsValidation()
        {
            var test = new StaffViewModel
            {
                FirstName = "123"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Must be only letters, unless your father is elon musk")), Is.True);
        }

        [Test]
        public void StaffViewModel_FirstNameStringTooShort_FailsValidation()
        {
            var test = new StaffViewModel
            {
                FirstName = "x"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("First name is too short.")));
        }

        [Test]
        public void StaffViewModel_FirstNameStringTooLong_FailsValidation()
        {
            var test = new StaffViewModel
            {
                FirstName = "ThisIsOneVeryLongName"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("First Name is too long.")));
        }

        [Test]
        public void StaffViewModel_FirstNameNotSupplied_FailsValidation()
        {
            var test = new StaffViewModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("FirstName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }


        [Test]
        public void StaffViewModel_LastNameStringContainingNumbers_FailsValidation()
        {
            var test = new StaffViewModel
            {
                LastName = "123"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Must be only letters, unless your father is elon musk")), Is.True);
        }

        [Test]
        public void StaffViewModel_LastNameStringTooShort_FailsValidation()
        {
            var test = new StaffViewModel
            {
                LastName = "x"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Last name is too short.")), Is.True);
        }

        [Test]
        public void StaffViewModel_LastNameStringTooLong_FailsValidation()
        {
            var test = new StaffViewModel
            {
                LastName = "ThisIsOneVeryLongName"
            };
            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Last Name is too long.")), Is.True);
        }

        [Test]
        public void StaffViewModel_LastNameNotSupplied_FailsValidation()
        {
            var test = new StaffViewModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("LastName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }

        [Test]
        public void StaffViewModel_AddressTooShort_FailsValidation()
        {
            var test = new StaffViewModel()
            {
                Address = "1"
            };

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Address")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Address is too short")), Is.True);
        }

        [Test]
        public void StaffViewModel_AddressNotSupplied_FailsValidation()
        {
            var test = new StaffViewModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Address")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }

        [Test]
        public void StaffViewModel_UserNameTooShort_FailsValidation()
        {
            var test = new StaffViewModel()
            {
                UserName = "abc"
            };

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("UserName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Username not long enough")), Is.True);
        }

        [Test]
        public void StaffViewModel_UserNameNotSupplied_FailsValidation()
        {
            var test = new StaffViewModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("UserName")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }

        [Test]
        public void StaffViewModel_PasswordTooShort_FailsValidation()
        {
            var test = new StaffViewModel()
            {
                Password = "abc"
            };

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Password")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("Password not long enough")), Is.True);
        }

        [Test]
        public void StaffViewModel_PasswordNotSupplied_FailsValidation()
        {
            var test = new StaffViewModel();

            Assert.That(ValidateModel(test).Any(x => x.MemberNames.Contains("Password")), Is.True);
            Assert.That(ValidateModel(test).Any(x => x.ErrorMessage.Contains("required")), Is.True);
        }
    }
}
