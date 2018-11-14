using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Caption { get; set; }

        public int Likes { get; set; }

        public int UserId { get; set; }
        public virtual TtUser User { get; set; }

        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
