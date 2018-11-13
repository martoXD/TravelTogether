using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class TripUser
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int TripId { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
