using Hackney.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hackney.Controllers
{
    internal class ApplicationRoleManager
    {
        private RoleStore<ApplicationRole> roleStore;

        public ApplicationRoleManager(RoleStore<ApplicationRole> roleStore)
        {
            this.roleStore = roleStore;
        }
    }
}