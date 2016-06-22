using System;

namespace Hackney.Core.Models
{
    public class Dashboard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public Notification Notification { get; set; }
        public Ticket Ticket { get; set; }
    }
}