namespace AppointmentBookingSystemDAL.DataAccess
{
    using AppointmentBookingSystemDAL.DataAccess.Interfaces;
    using Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class StaffData : IStaffData
    {
        private readonly ISqlDataAccess _dataAccess;

        public StaffData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<StaffModel>> GetAllStaff()
        {
            var query = "select * from MedPractice.staff";

            return _dataAccess.LoadData<StaffModel, dynamic>(query, new { });
        }

        public Task<List<StaffModel>> GetStaff(int staffId)
        {
            var query = @"select * from MedPractice.staff 
                          WHERE MedPractice.staff.ID = @staffId";

            return _dataAccess.LoadData<StaffModel, dynamic>(query, new { staffId });
        }

        public Task<List<StaffModel>> GetStaffFromCredentials(int credentialId)
        {
            var query = @"SELECT MedPractice.staff.* 
                          FROM MedPractice.staff
                          INNER JOIN MedPractice.usercredentials
                          ON MedPractice.staff.UserId = MedPractice.usercredentials.ID
                          WHERE MedPractice.usercredentials.ID = @credentialId";

            return _dataAccess.LoadData<StaffModel, dynamic>(query, new { credentialId });
        }

        public Task InsertStaff(StaffModel staffModel, UserCredentialsModel credentialModel)
        {
            var query = @"INSERT INTO MedPractice.usercredentials(username, password)
                                   VALUES(@UserName, @Password)
                          SET @UserId = SCOPE_IDENTITY()
                          INSERT INTO MedPractice.staff (FirstName, LastName, Address, RoleId, UserId)
                          VALUES (@FirstName, @LastName, @Address, @RoleId, @UserId)";

            return _dataAccess.SaveData(query, new
            {
                UserName=credentialModel.UserName, 
                Password=credentialModel.Password,
                FirstName=staffModel.FirstName,
                LastName=staffModel.LastName,
                Address=staffModel.Address, 
                RoleId=staffModel.RoleId,
                UserId=0
            });
        }

        public Task UpdateStaff(StaffModel staffModel)
        {
            var query = @"UPDATE MedPractice.staff 
                        SET FirstName=@FirstName, LastName=@LastName, Address=@Address, RoleId=@RoleId, UserId=@UserId
                        WHERE MedPractice.staff.ID = @Id";

            return _dataAccess.SaveData(query, staffModel);
        }

        public Task DeleteStaff(int staffId)
        {
            var query = @"DELETE
                          FROM MedPractice.appointment
                          WHERE MedPractice.appointment.staffId = @staffId;
                          DELETE
                          FROM MedPractice.staff
                          WHERE MedPractice.staff.ID = @staffId;";

            return _dataAccess.SaveData(query, new { staffId });
        }
    }
}
