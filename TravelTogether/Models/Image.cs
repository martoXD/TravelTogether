using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public byte[] ImageContent { get; set; }

        public int? TripId { get; set; }
        public virtual Trip Trip { get; set; }

        public int? UserId { get; set; }
        public virtual TtUser User { get; set; }

        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
