using System.Runtime.CompilerServices;

namespace AppointmentBookingSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PatientAddModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        [MinLength(2, ErrorMessage = "First name is too short.")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Must be only letters, unless your father is elon musk")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        [MinLength(2, ErrorMessage = "Last name is too short.")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Must be only letters, unless your father is elon musk")]
        public string LastName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Address is too short.")]
        public string Address { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "Phone Number is too long.")]
        [MinLength(6, ErrorMessage = "Phone Number not long enough")]
        [RegularExpression("[0-9]+")]
        public string ContactNumber { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Email not long enough")]
        [EmailAddress(ErrorMessage = "Email is invalid.")]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
    }
}
