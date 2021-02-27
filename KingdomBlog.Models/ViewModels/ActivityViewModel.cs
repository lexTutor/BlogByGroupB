using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class ActivityViewModel
    {
        public string FullName { get; set; }

        public string ActivityType { get; set; }

        public int PostId { get; set; }

        public string Comment { get; set; }
    }
}
