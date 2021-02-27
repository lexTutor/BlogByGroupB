using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class UserRecieverView
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PasswordHash { get; set; }

        public string Role { get; set; }

        public string PhoneNumber { get; set; }

        public string UserStory { get; set; }

        public string ProfilePhoto { get; set; }

    }
}
