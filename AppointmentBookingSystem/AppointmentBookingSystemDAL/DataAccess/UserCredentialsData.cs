using System.Data;
using AppointmentBookingSystemDAL.DataAccess.Interfaces;

namespace AppointmentBookingSystemDAL.DataAccess
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;

    public class UserCredentialsData : IUserCredentialsData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserCredentialsData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<UserCredentialsModel>> GetAllCredentials()
        {
            const string query = "select * from MedPractice.usercredentials";

            return _dataAccess.LoadData<UserCredentialsModel, dynamic>(query, new { });
        }

        public Task<List<UserCredentialsModel>> GetCredential(int credentialId)
        {
            const string query = @"select * from MedPractice.usercredentials 
                                   WHERE MedPractice.usercredentials.ID = @credentialId";

            return _dataAccess.LoadData<UserCredentialsModel, dynamic>(query, new {credentialId});
        }

        public Task<List<UserCredentialsModel>> GetCredentialFromLogin(string username, string password)
        {
            const string query = @"select * from MedPractice.usercredentials 
                                   WHERE MedPractice.usercredentials.UserName = @username
                                   AND MedPractice.usercredentials.Password = @password";

            return _dataAccess.LoadData<UserCredentialsModel, dynamic>(query, new { username = username, password = password });
        }

        public Task InsertCredentials(UserCredentialsModel credentials)
        {
            const string query = @"INSERT INTO MedPractice.usercredentials(username, password)
                                   VALUES(@UserName, @Password)";

            return _dataAccess.SaveData(query, credentials);
        }

        public Task UpdateCredentials(UserCredentialsModel credentials)
        {
            const string query = @"UPDATE MedPractice.usercredentials
                                   SET username=@UserName, password=@Password
                                   WHERE ID=@Id";

            return _dataAccess.SaveData(query, credentials);
        }

    }
}