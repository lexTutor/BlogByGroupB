using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomBlog.Models
{
    public class PostActivity
    {
        [Key]
        public int PostActivityiD { get; set; }

        [Required]
        public Post Post { get; set; }

        [Required]
        public PostActivityType PostActivityType { get; set; }

        public DateTime ActivityTime { get; set; } = DateTime.Now;

        [Required]
        public string UserFullName { get; set; }

        public string PostComment { get; set; }
    }
}
