using System.Collections.Generic;

namespace KingdomBlog.Models
{
    public class Category
    {
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

        public virtual ICollection<PostCategories> PostCategories { get; set; }

    }
}