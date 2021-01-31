using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess.Interfaces
{
    public interface IStaffData
    {
        Task<List<StaffModel>> GetAllStaff();
        Task<List<StaffModel>> GetStaff(int staffId);
        Task UpdateStaff(StaffModel staffModel);
        Task DeleteStaff(int staffId);
        Task InsertStaff(StaffModel staffModel, UserCredentialsModel credentialModel);
        Task<List<StaffModel>> GetStaffFromCredentials(int credentialId);
    }
}