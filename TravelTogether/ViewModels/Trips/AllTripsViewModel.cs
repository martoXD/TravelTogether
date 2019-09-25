using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TravelTogether.Models;

namespace TravelTogether.ViewModels.Trips
{
    public class AllTripsViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Country { get; set; }

        [Required]
        [MinLength(2)]
        public string City { get; set; }

        public string CreatorId { get; set; }
        public virtual TtUser Creator { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<TripUser> SignedUsers { get; set; }
    }
}
