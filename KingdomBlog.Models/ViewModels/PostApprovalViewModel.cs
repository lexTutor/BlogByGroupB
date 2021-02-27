using System;
using System.Collections.Generic;
using System.Text;

namespace KingdomBlog.Models.ViewModels
{
    public class PostApprovalViewModel
    {

        public int ArticleCategoryId { get; set; }

        public string Picture { get; set; }

        public string PostDetails { get; set; }

        public string PostCreatorName { get; set; }

        public string UserRole { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public int ApprovalState { get; set; }
    }
}
