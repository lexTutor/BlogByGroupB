using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class UserActivityType
    {
        public int ActivityTypeId { get; set; }

        [Required]
        public string ActivityTypeName { get; set; }
    }
}