namespace AppointmentBookingSystemDAL.Models
{
    public class StaffModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public int UserId { get; set; }
    }
}
