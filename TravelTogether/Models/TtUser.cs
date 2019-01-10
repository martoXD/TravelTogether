using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelTogether.Models.enums;

namespace TravelTogether.Models
{
    public class TtUser : IdentityUser
    {
        public TtUser()
        {
            this.MainUserFriends = new HashSet<FriendShip>();
            this.Friends = new HashSet<FriendShip>();
            this.Posts = new HashSet<Post>();
            this.SentMessages = new HashSet<Message>();
            this.ReceivedMessages = new HashSet<Message>();
            this.SignedTrips = new HashSet<TripUser>();
            this.Images = new HashSet<Image>();
            this.Comments = new HashSet<Comment>();
            this.Likes = new HashSet<Like>();
        }

        [Required]
        [StringLength(20)]
        public override string UserName { get => base.UserName; set => base.UserName = value; }

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

        public int? ProfileImageId { get; set; } = null;

        public string ProfileImageSrc { get; set; }
        
        public string DefaultImageSrc { get; set; }

        [InverseProperty("TtUser")]
        public virtual ICollection<FriendShip> MainUserFriends { get; set; }

        [InverseProperty("Friend")]
        public virtual ICollection<FriendShip> Friends { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        [InverseProperty("Sender")]
        public virtual ICollection<Message> SentMessages { get; set; }

        [InverseProperty("Receiver")]
        public virtual ICollection<Message> ReceivedMessages { get; set; }
        
        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<TripUser> SignedTrips { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Like> Likes { get; set; }
    }
}
