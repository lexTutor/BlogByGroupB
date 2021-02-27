using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class UserActivity
    {
        public int UserActivityId { get; set; }

        [Required]
        public UserActivityType ActivityType { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }

        public string DeletedUserDetails { get; set; }
    }
}