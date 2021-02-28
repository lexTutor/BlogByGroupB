using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class BlogRole
    {
        [Required]
        public string UserRole { get; set; }

        [Key]
        public int BlogRoleId { get; set; }

        public virtual ICollection<BlogUser> Users { get; set; }
    }
}