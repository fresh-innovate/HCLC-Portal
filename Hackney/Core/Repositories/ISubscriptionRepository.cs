using Hackney.Core.Models;
using System.Collections.Generic;

namespace Hackney.Core.Repositories
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> GetSubscription(string userId);
    }
}