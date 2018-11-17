using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class TripUser
    {
        public string TtUserId { get; set; }
        public virtual TtUser TtUser { get; set; }

        public int TripId { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
