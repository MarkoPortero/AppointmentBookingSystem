using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess.Interfaces
{
    public interface IAppointmentData
    {
        Task<List<AppointmentModel>> GetAllAppointments();
        Task<List<AppointmentModel>> GetAllAppointmentsForPatient(int patientId);
        Task<List<AppointmentModel>> GetAllAppointmentsForStaffMember(int staffId);
        Task<List<AppointmentModel>> GetAppointment(int appointmentId);
        Task InsertAppointment(AppointmentModel appointment);
        Task UpdateAppointment(AppointmentModel appointment);
        Task DeleteAppointment(int appointmentId);
    }
}