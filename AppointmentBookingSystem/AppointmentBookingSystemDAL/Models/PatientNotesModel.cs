using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentBookingSystemDAL.Models
{
    public class PatientNotesModel
    {
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public string PatientNotes { get; set; }
    }
}
