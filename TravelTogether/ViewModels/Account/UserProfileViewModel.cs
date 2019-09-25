using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;
using TravelTogether.Models.enums;

namespace TravelTogether.ViewModels.Account
{
    public class UserProfileViewModel
    {
        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(100)]
        public string AboutMeDescription { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public int ProfileImageId { get; set; }

        public string ProfileImageSrc { get; set; }

        public string DefaultImageSrc { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
