﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AppointmentBookingSystemDAL.Models;

namespace AppointmentBookingSystemDAL.DataAccess
{
    public interface IUserRoleData
    {
        Task<List<UserRolesModel>> GetAllUserRoles();
        Task<List<UserRolesModel>> GetUserRole(int userRoleId);
    }
}