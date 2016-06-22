using System;

namespace Hackney.Core.Models
{
    public class Case
    {
        public int Id { get; set; }
        public CaseSubject CaseSubject { get; set; }
        public string Details { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime CreatIDate { get; set; }

    }
}