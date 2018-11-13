using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class UserFriend
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int FriendId { get; set; }
        public virtual User Friend { get; set; }
    }
}
