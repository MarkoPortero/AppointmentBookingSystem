namespace AppointmentBookingSystemDAL.DataAccess
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;

    public interface IPatientData
    {
        Task<List<PatientModel>> GetAllPatients();
        Task InsertPatient(PatientModel patient);
        Task<List<PatientModel>> GetPatient(int patientId);
        Task DeletePatient(int patientId);
        Task UpdatePatient(PatientModel patient);
    }
}