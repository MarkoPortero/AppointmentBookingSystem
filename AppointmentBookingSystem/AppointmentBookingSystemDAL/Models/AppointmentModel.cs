using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentBookingSystemDAL.Models
{
    public class AppointmentModel
    {
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public DateTime AppointmentDuration { get; set; }
    }
}
