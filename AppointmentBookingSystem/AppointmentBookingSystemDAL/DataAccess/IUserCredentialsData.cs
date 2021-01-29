using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess
{
    public interface IUserCredentialsData
    {
        Task<List<UserCredentialsModel>> GetAllCredentials();
        Task<List<UserCredentialsModel>> GetCredential(int credentialId);
        Task UpdateCredentials(UserCredentialsModel credentials);
    }
}