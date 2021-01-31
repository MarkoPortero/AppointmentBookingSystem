
using System;

namespace AppointmentBookingSystemDAL.DataAccess
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;
    using AppointmentBookingSystemDAL.DataAccess.Interfaces;

    public class AppointmentData : IAppointmentData
    {
        private readonly ISqlDataAccess _dataAccess;

        public AppointmentData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<AppointmentModel>> GetAllAppointments()
        {
            const string query = @"SELECT MedPractice.appointment.ID, MedPractice.appointment.staffId,  
                                          MedPractice.appointment.patientId, MedPractice.appointment.appointmentDatetime, 
                                          MedPractice.appointment.appointmentDuration, MedPractice.patient.FirstName AS PatientFirstname, MedPractice.patient.LastName AS PatientLastname,
                                          MedPractice.staff.FirstName AS StaffFirstName, MedPractice.staff.LastName AS StaffLastName
                                   FROM MedPractice.appointment
                                   INNER JOIN MedPractice.patient
                                   ON appointment.patientId = MedPractice.patient.ID
                                   INNER JOIN MedPractice.staff
                                   ON appointment.staffId = MedPractice.staff.ID";

            return _dataAccess.LoadData<AppointmentModel, dynamic>(query, new { });
        }

        public Task<List<AppointmentModel>> GetAppointment(int appointmentId)
        {
            const string query = @"SELECT MedPractice.appointment.ID, MedPractice.appointment.staffId,  
                                          MedPractice.appointment.patientId, MedPractice.appointment.appointmentDatetime, 
                                          MedPractice.appointment.appointmentDuration, MedPractice.patient.FirstName AS PatientFirstname, MedPractice.patient.LastName AS PatientLastname,
                                          MedPractice.staff.FirstName AS StaffFirstName, MedPractice.staff.LastName AS StaffLastName
                                   FROM MedPractice.appointment
                                   INNER JOIN MedPractice.patient
                                   ON appointment.patientId = MedPractice.patient.ID
                                   INNER JOIN MedPractice.staff
                                   ON appointment.staffId = MedPractice.staff.ID
                                   WHERE appointment.ID = @appointmentId";

            return _dataAccess.LoadData<AppointmentModel, dynamic>(query, new { appointmentId });
        }
        public Task<List<AppointmentModel>> GetAllAppointmentsForPatient(int patientId)
        {
            const string query = @"SELECT * FROM MedPractice.appointment
                                   WHERE MedPractice.appointment.patientId = @patientId";
            
            return _dataAccess.LoadData<AppointmentModel, dynamic>(query, new { patientId });
        }

        public Task<List<AppointmentModel>> GetAllAppointmentsForStaffMember(int staffId)
        {
            const string query = @"SELECT * FROM MedPractice.appointment
                                   WHERE MedPractice.appointment.staffID = @staffId";

            return _dataAccess.LoadData<AppointmentModel, dynamic>(query, new { staffId = staffId });
        }

        public Task<List<AppointmentModel>> GetAllAppointmentsForStaffMemberFromCredentials(int credentialId)
        {
            const string query = @"SELECT MedPractice.appointment.*, MedPractice.patient.FirstName AS PatientFirstname, MedPractice.patient.LastName AS PatientLastname,
                                          MedPractice.staff.FirstName AS StaffFirstName, MedPractice.staff.LastName AS StaffLastName
                                   FROM MedPractice.appointment
                                   INNER JOIN MedPractice.staff ON MedPractice.appointment.staffID = MedPractice.staff.ID
                                   INNER JOIN MedPractice.usercredentials ON MedPractice.staff.UserId = MedPractice.usercredentials.ID
                                   INNER JOIN MedPractice.patient ON MedPractice.appointment.patientId = MedPractice.patient.Id
                                   WHERE MedPractice.usercredentials.ID = @credentialId";

            return _dataAccess.LoadData<AppointmentModel, dynamic>(query, new { credentialId = credentialId });
        }

        public Task InsertAppointment(AppointmentModel appointment)
        {
            const string query = @"INSERT INTO MedPractice.appointment(staffID, patientId, appointmentDatetime, appointmentDuration)
                                   VALUES(@staffID, @patientId, @appointmentDatetime, @appointmentDuration)";

            return _dataAccess.SaveData(query, new
            {
                staffID = appointment.StaffId, 
                patientId = appointment.PatientId,
                appointmentDatetime = appointment.AppointmentDateTime,
                appointmentDuration = appointment.AppointmentDuration
            });
        }

        public Task UpdateAppointment(AppointmentModel appointment)
        {
            const string query = @"UPDATE MedPractice.appointment
                                   SET staffID=@staffID, patientId=@patientId, 
                                       appointmentDatetime=@appointmentDatetime, appointmentDuration=@appointmentDuration
                                   WHERE ID = @ID";

            return _dataAccess.SaveData(query, new
            {
                ID = appointment.Id,
                staffID = appointment.StaffId,
                patientId = appointment.PatientId,
                appointmentDatetime = appointment.AppointmentDateTime,
                appointmentDuration = appointment.AppointmentDuration
            });
        }

        public Task DeleteAppointment(int appointmentId)
        {
            var query = @"DELETE 
                          FROM MedPractice.appointment 
                          WHERE MedPractice.appointment.ID = @appointmentId";

            return _dataAccess.SaveData(query, new { appointmentId });
        }
    }
}
