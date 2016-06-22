using System;

namespace Hackney.Core.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public ApplicationUser User { get; set; }
        public bool IsCanceled { get; private set; }
        public DateTime DateTime { get; set; }
    }
}