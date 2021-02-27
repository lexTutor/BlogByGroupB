using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class PostViewModel
    {
        public string ArticleCategoryId { get; set; }

        public string Picture { get; set; }

        public string PostDetails { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
