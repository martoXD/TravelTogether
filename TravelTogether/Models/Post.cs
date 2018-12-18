using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(40)]
        public string Caption { get; set; }

        public int Likes { get; set; }

        public DateTime CreatedOn { get; set; }

        [ForeignKey("TtUser")]
        public string TtUserId { get; set; }
        public virtual TtUser TtUser { get; set; }

        [ForeignKey("Image")]
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
