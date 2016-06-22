using System;

namespace Hackney.Core.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DocumentType DocumentType { get; set; }
        public DateTime UploadedAt { get; set; }

    }
}