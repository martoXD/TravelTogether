using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;

namespace TravelTogether.ViewModels.Home
{
    public class AllUsersViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(100)]
        public string AboutMeDescription { get; set; }

        public int? ProfileImageId { get; set; }

        public string ProfileImageSrc { get; set; }

        public string DefaultImageSrc { get; set; }
        
        public virtual ICollection<FriendShip> MainUserFriends { get; set; }
        
        public virtual ICollection<FriendShip> Friends { get; set; }
    }
}
