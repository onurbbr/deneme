using System.ComponentModel.DataAnnotations;

namespace SporcialAPI.Domain.Entities
{
    public class UserActivity
    {
        [Key]
        public Guid ActivityId { get; set; }
        public string? ActivityType { get; set; }
        public int? ActivityDuration { get; set; }
        public DateTime? ActivityDate { get; set; }
    }
}
