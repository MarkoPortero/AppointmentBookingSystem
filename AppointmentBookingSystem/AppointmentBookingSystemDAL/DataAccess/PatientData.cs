namespace AppointmentBookingSystemDAL.DataAccess
{
    using AppointmentBookingSystemDAL.DataAccess.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;

    public class PatientData : IPatientData
    {
        private readonly ISqlDataAccess _dataAccess;

        public PatientData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<PatientModel>> GetAllPatients()
        {
            var query = "select * from MedPractice.patient";

            return _dataAccess.LoadData<PatientModel, dynamic> (query, new { });
        }

        public Task<List<PatientModel>> GetPatient(int patientId)
        {
            var query = @"select * from MedPractice.patient 
                          WHERE MedPractice.patient.ID = @patientId";

            return _dataAccess.LoadData<PatientModel, dynamic>(query, new{patientId});
        }

        public Task DeletePatient(int patientId)
        {
            var query = @"DELETE
                          FROM MedPractice.appointment
                          WHERE MedPractice.appointment.patientId = @patientId;
                          DELETE 
                          FROM MedPractice.patient 
                          WHERE MedPractice.patient.ID = @patientId;";
                        

            return _dataAccess.SaveData(query, new{patientId});
        }

        public Task UpdatePatient(PatientModel patient)
        {
            var query = @"UPDATE MedPractice.patient
                          SET FirstName=@FirstName, LastName=@LastName, Address=@Address, ContactNumber=@ContactNumber, email=@Email, dateOfBirth=@dateOfBirth
                          WHERE ID = @ID";
            return _dataAccess.SaveData(query, patient);
        }

        public Task InsertPatient(PatientModel patient)
        {
            var query = @"INSERT INTO MedPractice.patient (FirstName, LastName, Address, ContactNumber, email, dateOfBirth)
                          VALUES (@FirstName, @LastName, @Address, @ContactNumber, @Email, @dateOfBirth);";

            return _dataAccess.SaveData(query, patient);
        }
    }
}
