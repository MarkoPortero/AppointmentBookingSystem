using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL
{
    public class PatientData : IPatientData
    {
        private readonly ISqlDataAccess _dataAccess;

        public PatientData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<PatientModel>> GetPatients()
        {
            var query = "select * from MedPractice.patient";

            return _dataAccess.LoadData<PatientModel, dynamic> (query, new { });
        }

        public Task<List<PatientModel>> GetPatient(string firstName, string lastName, DateTime dateOfBirth)
        {
            var query = @"select * from MedPractice.patient 
                          WHERE MedPractice.patient.FirstName LIKE'@firstName' 
                          AND MedPractice.patient.LastName LIKE '@lastName'
                          AND MedPractice.patient.dateOfBirth LIKE '@dateOfBirth'";

            return _dataAccess.LoadData<PatientModel, dynamic>(query, new {firstName, lastName, dateOfBirth});
        }

        public Task InsertPatient(PatientModel patient)
        {
            var query = @"INSERT INTO MedPractice.patient (FirstName, LastName, Address, ContactNumber, email, dateOfBirth)
                             VALUES (@FirstName, @LastName, @Address, @ContactNumber, @Email, @dateOfBirth);";

            return _dataAccess.SaveData(query, patient);
        }
    }
}
