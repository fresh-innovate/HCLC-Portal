using System;
using System.ComponentModel.DataAnnotations;

namespace Hackney.Core.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; private set; }

        [Required]
        public Subscription Subsciption { get; private set; }

        protected Notification()
        {
        }

        private Notification(NotificationType type, Subscription subsciption)
        {
            if (Subsciption == null)
                throw new ArgumentNullException("Subsciption");

            Type = type;
            Subsciption = subsciption;
            DateTime = DateTime.Now;
        }

        public static Notification SubsciptionCreated(Subscription subsciption)
        {
            return new Notification(NotificationType.SubsciptionCreated, subsciption);
        }

        public static Notification SubsciptionUpdated(Subscription newSubsciption, DateTime originalDateTime, string originalVenue)
        {
            var notification = new Notification(NotificationType.SubsciptionUpdated, newSubsciption);
            notification.OriginalDateTime = originalDateTime;
            return notification;
        }

        public static Notification SubsciptionCanceled(Subscription subsciption)
        {
            return new Notification(NotificationType.SubsciptionCanceled, subsciption);
        }
    }
}