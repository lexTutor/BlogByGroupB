using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomBlog.Models
{
    public class PostActivity
    {
        public int PostActivityiD { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }

        [Required]
        public int PostActivityTypeId { get; set; }

        public PostActivityType PostActivityType { get; set; }

        [Required]
        public string UserFullName { get; set; }

        public string PostComment { get; set; }
    }
}
