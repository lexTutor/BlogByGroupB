using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KingdomBlog.Models
{
    public class PostActivityType
    {
        [Required]
        public int PostActivityTypeId { get; set; }

        [Required]
        public string PostActivity { get; set; }

        public virtual ICollection<PostActivity> PostActivities { get; set;
        }

    }
}
