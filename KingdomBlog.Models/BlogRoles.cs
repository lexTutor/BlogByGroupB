using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class BlogRoles
    {
        [Required]
        public string UserRole { get; set; }

        [Required]
        public int RoleId { get; set; }

        public virtual ICollection<BlogUser> Users { get; set; }
    }
}