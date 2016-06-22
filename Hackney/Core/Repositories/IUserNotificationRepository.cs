using Hackney.Core.Models;
using System.Collections.Generic;

namespace Hackney.Core.Repositories
{
    public interface IUserNotificationRepository
    {
        IEnumerable<UserNotification> GetUserNotificationsFor(string userId);
    }
}