using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class PostCategories
    {
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }
    }
}
