using Hackney.Core.Models;
using Hackney.Persistence;
using Hackney.Persistence.Migrations;
using NUnit.Framework;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Hackney.IntergrationTest
{
    [SetUpFixture]
    public class GlobalSetUp
    {
        
        public void SetUp()
        {
            MigrateDbToLatestVersion();
            Seed();
        }

        private static void MigrateDbToLatestVersion()
        {
            var configuration = new Configuration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }

        public void Seed()
        {
            var context = new ApplicationDbContext();

            if (context.Users.Any())
                return; 

            context.Users.Add(new ApplicationUser { UserName = "user1", Name = "Firstname", Email = "-", PasswordHash = "-" });
            context.Users.Add(new ApplicationUser { UserName = "user2", Name = "Secondname", Email = "-", PasswordHash = "-" });
            context.SaveChanges();
        }
    }
}
