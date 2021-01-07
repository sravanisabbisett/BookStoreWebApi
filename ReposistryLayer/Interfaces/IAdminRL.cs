using commonLayerr.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReposistryLayer.Interfaces
{
    public interface IAdminRL
    {
        bool RegisterAdmin(AdminUserRegistration admin);

        //List<EmployeeModel> GetAllEmployee();

        AdminUserRegistration AdminLogin(AdminUserLogin login);
        //EmployeeModel EmployeeLogin(AdminLogin login);
    }
}
