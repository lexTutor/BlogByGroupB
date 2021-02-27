using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class AdminDetailsViewModel
    {
        public int UserId { get;}

        public string FullName { get; set; }

        public string UserRole { get; set; }

        public int ArticleCount { get; set; }

        public int ActivityCount { get; set; }
    }
}
