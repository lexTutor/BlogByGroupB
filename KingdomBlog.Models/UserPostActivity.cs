using System;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class UserPostActivity
    {
        [Key]
        public int UserPostActivityId { get; set; }

        [Required]
        public BlogUser BlogUser { get; set; }

        [Required]
        public UserActivityType ActivityType { get; set; }

        [Required]
        public Post Post { get; set; }

        public DateTime ActivityTime { get; set; } = DateTime.Now;

    }
}