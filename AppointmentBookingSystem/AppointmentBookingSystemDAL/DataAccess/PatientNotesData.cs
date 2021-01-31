namespace AppointmentBookingSystemDAL.DataAccess
{
    using AppointmentBookingSystemDAL.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class PatientNotesData : IPatientNotesData
    {
        private readonly ISqlDataAccess _dataAccess;

        public PatientNotesData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<PatientNotesModel>> GetPatientNotes(int appointmentId)
        {
            const string query = @"select * 
                                   FROM MedPractice.patientNotes
                                   WHERE MedPractice.patientNotes.appointmentId = @appointmentId";

            return _dataAccess.LoadData<PatientNotesModel, dynamic>(query, new { appointmentId = appointmentId });
        }

        public Task UpsertPatientNotes(PatientNotesModel patientNotes)
        {
            const string query = @"IF EXISTS ( SELECT * FROM MedPractice.patientNotes WHERE MedPractice.patientNotes.appointmentId = @appointmentId)
                                    UPDATE MedPractice.patientNotes
                                    SET MedPractice.patientNotes.PatientNotes = @patientNotes
                                    WHERE MedPractice.patientNotes.appointmentId = @appointmentId
                                   ELSE
                                    INSERT INTO MedPractice.patientNotes(staffId, patientId, patientNotes, appointmentID)
                                    VALUES (@staffId, @patientId, @patientNotes, @appointmentId)";
                
            return _dataAccess.SaveData(query, new
            {
                patientId = patientNotes.PatientId, 
                appointmentId = patientNotes.AppointmentId, 
                patientNotes = patientNotes.PatientNotes, 
                staffId = patientNotes.StaffId
            });
        }
    }
}
