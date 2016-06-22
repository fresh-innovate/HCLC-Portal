using Hackney.Core.Repositories;

namespace Hackney.Core
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository Users { get; }
        INotificationRepository Notifications { get; }
        IUserNotificationRepository UserNotifications { get; }
        void Complete();
    }
}