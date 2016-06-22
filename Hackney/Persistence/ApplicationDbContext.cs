using Hackney.Controllers;
using Hackney.Core.Models;
using Hackney.Persistence.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace Hackney.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Subscription> Subsciption { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationUserConfiguration());
            modelBuilder.Configurations.Add(new NotificationConfiguration());
            modelBuilder.Configurations.Add(new UserNotificationConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        internal void CreateRole(ApplicationRoleManager _roleManager, string roleName, string description)
        {
            throw new NotImplementedException();
        }

        internal bool RoleExists(ApplicationRoleManager _roleManager, string roleName)
        {
            throw new NotImplementedException();
        }

        internal void DeleteRole(ApplicationDbContext _db, ApplicationUserManager userManager, string id)
        {
            throw new NotImplementedException();
        }


        bool AddUserAndRoles()
        {
            bool success = false;
            var idManager = new IdentityManager();

            success = idManager.CreateRole("Admin", "Global Access");
            if (!success == true) return success;

            success = idManager.CreateRole("CanEdit", "Edit existing records");
            if (!success == true) return success;

            success = idManager.CreateRole("User", "Restricted to business domain activity");
            if (!success) return success;

            var newUser = new ApplicationUser()
            {
                UserName = "peter",
                Email = "p@yahoo.com"
            };

            success = idManager.CreateUser(newUser, "Password1");
            if (!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "Admin");
            if (!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "CanEdit");
            if (!success) return success;

            success = idManager.AddUserToRole(newUser.Id, "User");
            if (!success) return success;

            return success;
        }
    }
}