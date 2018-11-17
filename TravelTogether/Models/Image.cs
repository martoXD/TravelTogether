using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public byte[] ImageContent { get; set; }

        [ForeignKey("Trip")]
        public int? TripId { get; set; }
        public virtual Trip Trip { get; set; }

        [ForeignKey("TtUser")]
        public string TtUserId { get; set; }
        public virtual TtUser TtUser { get; set; }
        
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
