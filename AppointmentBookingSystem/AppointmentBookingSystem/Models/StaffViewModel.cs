namespace AppointmentBookingSystem.Models
{
    using System.ComponentModel.DataAnnotations;
    public class StaffViewModel
    {
        public int Id { get; set; }
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
        public string Role { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Username not long enough")]
        public string UserName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password not long enough")]
        public string Password { get; set; }
    }
}
