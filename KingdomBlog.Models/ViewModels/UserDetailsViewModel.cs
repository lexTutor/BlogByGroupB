using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class UserDetailsViewModel
    {
        public string UserId { get; }

        public string FullName { get; set; }

        public string UserRole  { get; set; }
       
        public int ActivityCount { get; set; }
    }
}
