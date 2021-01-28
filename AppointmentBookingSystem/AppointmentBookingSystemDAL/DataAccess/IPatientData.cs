using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL
{
    public interface IPatientData
    {
        Task<List<PatientModel>> GetPatients();
        Task InsertPatient(PatientModel patient);
    }
}