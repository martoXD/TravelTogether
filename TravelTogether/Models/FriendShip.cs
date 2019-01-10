using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class FriendShip
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TtUser")]
        public string TtUserId { get; set; }
        public virtual TtUser TtUser { get; set; }

        [ForeignKey("Friend")]
        public string FriendId { get; set; }
        public virtual TtUser Friend { get; set; }
    }
}
