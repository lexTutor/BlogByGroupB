using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomBlog.Models
{
    public class BlogUser
    {
        public int BlogUserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int RoleId { get; set; }

        public BlogRole UserRole { get; set; }

        public string PhoneNumber { get; set; }

        public string UserStory { get; set; }

        public string ProfilePhoto { get; set; }

        public virtual ICollection<UserActivity> UserActivity { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
