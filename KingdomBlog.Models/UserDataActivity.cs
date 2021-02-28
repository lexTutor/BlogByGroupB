using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KingdomBlog.Models
{
    public class UserDataActivity
    {
        [Key]
        public int UserDataActivityId { get; set; }

        [Required]
        public BlogUser BlogUser  { get; set; }

        [Required]
        public UserActivityType ActivityType { get; set; }

        public int UserActivityTypeId { get; set; }

        public DateTime ActivityTime { get; set; } = DateTime.Now;
    }
}
