namespace AppointmentBookingSystemDAL.DataAccess
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

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

        public Task InsertStaff(StaffModel staffModel)
        {
            var query = @"INSERT INTO MedPractice.staff (FirstName, LastName, Address, RoleId, UserId)
                          VALUES (@FirstName, @LastName, @Address, @ContactNumber, @RoleId, @UserId)";

            return _dataAccess.SaveData(query, staffModel);
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
                          FROM MedPractice.staff
                          WHERE MedPractice.staff.ID = @staffId";

            return _dataAccess.SaveData(query, new { staffId });
        }
    }
}
