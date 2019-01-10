using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Like
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        [Required]
        [ForeignKey("TtUser")]
        public string TtUserId { get; set; }
        public virtual TtUser TtUser { get; set; }
    }
}
