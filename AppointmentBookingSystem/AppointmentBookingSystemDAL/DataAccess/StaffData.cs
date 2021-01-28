namespace AppointmentBookingSystemDAL
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AppointmentBookingSystemDAL.Models;

    public class StaffData
    {
        private readonly ISqlDataAccess _dataAccess;

        public StaffData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<StaffModel>> GetStaff()
        {
            var query = "select * from MedPractice.staff";

            return _dataAccess.LoadData<StaffModel, dynamic>(query, new { });
        }

        public Task InsertStaff(StaffModel staffModel)
        {
            var query = @"INSERT INTO MedPractice.staff (FirstName, LastName, Address, RoleId, UserId)
                          VALUES (@FirstName, @LastName, @Address, @ContactNumber, @RoleId, @UserId);";

            return _dataAccess.SaveData(query, staffModel);
        }
    }
}
