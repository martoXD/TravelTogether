using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Replies = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string CommentContent { get; set; }

        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public virtual ICollection<Comment> Replies { get; set; }
    }
}
