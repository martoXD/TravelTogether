using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.Models
{
    public class Trip
    {
        public Trip()
        {
            this.Images = new HashSet<Image>();
            this.SignedUsers = new HashSet<TripUser>();
        }

        [Key]
        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<TripUser> SignedUsers { get; set; }
    }
}
