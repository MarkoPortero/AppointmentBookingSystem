using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentBookingSystemDAL.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTime { get; set; } = DateTime.UtcNow;
        public int AppointmentDuration { get; set; }
        public string PatientFirstname { get; set; }
        public string PatientLastname { get; set; }

        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }

    }
}
