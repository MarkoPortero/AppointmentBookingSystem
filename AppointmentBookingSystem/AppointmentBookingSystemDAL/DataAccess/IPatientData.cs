using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess
{
    public interface IPatientData
    {
        Task<List<PatientModel>> GetPatients();
        Task InsertPatient(PatientModel patient);
        Task<List<PatientModel>> GetPatient(int patientId);
        Task DeletePatient(int patientId);
        Task UpdatePatient(PatientModel patient);
    }
}