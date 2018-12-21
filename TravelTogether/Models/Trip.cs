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
