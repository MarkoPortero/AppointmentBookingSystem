namespace AppointmentBookingSystemDAL.Models
{
    public class PatientNotesModel
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public string PatientNotes { get; set; }
    }
}
