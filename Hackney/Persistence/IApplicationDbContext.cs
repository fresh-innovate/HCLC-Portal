using Hackney.Core.Models;
using System.Data.Entity;

namespace Hackney.Persistence
{
    public interface IApplicationDbContext
    {
        
        DbSet<Notification> Notifications { get; set; }
        DbSet<UserNotification> UserNotifications { get; set; }
        IDbSet<ApplicationUser> Users { get; set; }
    }
}