using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class UserActivityType
    {
        public int UserActivityTypeId { get; set; }

        [Required]
        public string ActivityTypeName { get; set; }

        public virtual ICollection<UserPostActivity> UserPostActivities { get; set; }
        public virtual ICollection<UserDataActivity> UserDataActivities { get; set; }

    }
}