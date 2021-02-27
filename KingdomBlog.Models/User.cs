using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomBlog.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public int RoleId { get; set; }

        public Role UserRole { get; set; }

        public string PhoneNumber { get; set; }

        public string UserStory { get; set; }

        public string ProfilePhoto { get; set; }

        public UserActivity UserActiity { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
