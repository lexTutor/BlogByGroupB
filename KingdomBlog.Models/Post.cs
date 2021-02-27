using System;
using System.Collections.Generic;

namespace KingdomBlog.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public BlogUser PostCreator { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<PostCategories> PostCategories { get; set; }
        public virtual ICollection<PostActivity> PostActivities { get; set; }

        public string PostDetails { get; set; }

        public int ArticleCategoryId { get; set; }

        public int ApprovalState { get; set; }

        public int LikeCount { get; set; }

        public string Picture { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;


    }
}