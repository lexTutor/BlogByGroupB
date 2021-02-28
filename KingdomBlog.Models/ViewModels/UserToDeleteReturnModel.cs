using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class UserToDeleteReturnModel
    {
        public string UserId { get; }

        public string FullName { get; set; }

        public string UserRole { get; set; }
    }
}
