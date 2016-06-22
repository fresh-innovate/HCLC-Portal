namespace Hackney.Core.Models
{
    public class Portal
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Accessibility { get; set; }
        public string Setting { get; set; }
        public Dashboard Dashboard { get; set; }
    }
}
