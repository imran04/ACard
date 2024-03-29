﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Web.Security;

namespace Offers.Core
{
    public class DataContextInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            MembershipCreateStatus Status;
            Membership.CreateUser("Admin", "password", "Admin@offers.com", null, null, true, out Status);
            Roles.CreateRole("Admin");
            Roles.AddUserToRole("Admin", "Admin");
        }
    }
}
