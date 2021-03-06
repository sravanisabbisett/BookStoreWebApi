﻿using BusinessLayer.Interfaces;
using commonLayerr.Models;
using ReposistryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class AdminBL : IAdminBL
    {
        private readonly IAdminRL adminRL;

        public AdminBL(IAdminRL adminRL)
        {
            this.adminRL = adminRL;
        }

        public AdminUserRegistration AdminLogin(AdminUserLogin login)
        {
            try
            {
                return this.adminRL.AdminLogin(login);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool RegisterAdmin(AdminUserRegistration admin)
        {
            try
            {
                return this.adminRL.RegisterAdmin(admin);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
