using System.Collections.Generic;
using System.Threading.Tasks;
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
    }
}
