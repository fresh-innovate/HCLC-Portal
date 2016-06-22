using Hackney.Core.Models;
using System.Collections.Generic;

namespace Hackney.Core.Repositories
{
    public interface INotificationRepository
    {
        IEnumerable<Notification> GetNewNotificationsFor(string userId);
    }
}