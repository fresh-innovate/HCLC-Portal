using System;

namespace Hackney.Core.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public Case Case { get; set; }
    }
}