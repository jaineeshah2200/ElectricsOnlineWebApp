using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp.Models
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {

            var admin = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Admin" };

            context.Roles.Add(admin);

            base.Seed(context);
        }
    }
}