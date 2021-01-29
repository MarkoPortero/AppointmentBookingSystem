namespace AppointmentBookingSystemDAL.DataAccess
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;

    public interface IStaffData
    {
        Task<List<StaffModel>> GetAllStaff();
        Task<List<StaffModel>> GetStaff(int staffId);
        Task UpdateStaff(StaffModel staffModel);
        Task DeleteStaff(int staffId);
    }
}