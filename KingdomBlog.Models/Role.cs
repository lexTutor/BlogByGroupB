using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class Role
    {
        [Required]
        public string UserRole { get; set; }

        [Required]
        public int RoleId { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}