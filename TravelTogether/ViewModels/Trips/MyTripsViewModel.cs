using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;

namespace TravelTogether.ViewModels.Trips
{
    public class MyTripsViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Country { get; set; }

        [Required]
        [MinLength(2)]
        public string City { get; set; }

        public string CreatorId { get; set; }
        public TtUser Creator { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<TripUser> SignedUsers { get; set; }
    }
}
