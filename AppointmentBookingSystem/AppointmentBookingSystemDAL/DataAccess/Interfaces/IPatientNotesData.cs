using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess
{
    public interface IPatientNotesData
    {
        Task<List<PatientNotesModel>> GetPatientNotes(int appointmentId);
        Task UpsertPatientNotes(PatientNotesModel patientNotes);
    }
}