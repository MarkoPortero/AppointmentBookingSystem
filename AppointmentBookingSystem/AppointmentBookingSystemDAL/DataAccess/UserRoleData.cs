using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.DataAccess.Interfaces;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess
{
    public class UserRoleData : IUserRoleData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserRoleData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<UserRolesModel>> GetAllUserRoles()
        {
            const string query = "select * from MedPractice.userRole";

            return _dataAccess.LoadData<UserRolesModel, dynamic>(query, new { });
        }

        public Task<List<UserRolesModel>> GetUserRole(int credentialId)
        {
            const string query = @"select * from MedPractice.userRole 
                                   WHERE MedPractice.userRole.ID = @credentialId";

            return _dataAccess.LoadData<UserRolesModel, dynamic>(query, new { credentialId });
        }


        public Task<List<UserRolesModel>> GetUserRoleFromLogin(int id)
        {
            const string query = @"SELECT MedPractice.userRole.ID, userRole
                                   FROM MedPractice.userRole
                                   INNER JOIN MedPractice.staff
                                   ON MedPractice.staff.RoleId = userRole.ID
                                   WHERE MedPractice.staff.UserId = @userId";

            return _dataAccess.LoadData<UserRolesModel, dynamic>(query, new { userId = id });
        }
    }
}
