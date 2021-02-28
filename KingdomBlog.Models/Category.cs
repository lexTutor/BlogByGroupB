using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KingdomBlog.Models
{
    public class Category
    {
        public string CategoryName { get; set; }

        [Key]
        public int CategoryId { get; set; }

        public virtual ICollection<PostCategories> PostCategories { get; set; }

    }
}