using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TravelTogether.Models.enums;

namespace TravelTogether.Models
{
    public class User : IdentityUser<int>
    {
        //-int Id		
        //-string FirstName
        //-string LastName
        //-string ProfilePhoto
        //-string Country
        //-string City
        //-string AboutMeDescription
        //-Gender Gender(enum)
        //-ICollection<User> Friends(Users)
        //-ICollection<Post> Posts(Posts)
        //-ICollection<Message> Messages 
        //-ICollection<Trip> Trips

        public User()
        {
            this.Friends = new HashSet<User>();
            this.Posts = new HashSet<Post>();
            this.ReceivedMessages = new HashSet<Message>();
            this.SentMessages = new HashSet<Message>();
            this.DeletedMessages = new HashSet<Message>();
            this.SignedTrips = new HashSet<Trip>();
            this.Images = new HashSet<Image>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public byte[] ProfileImage { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
        
        public int Age { get; set; }

        [DataType(DataType.MultilineText)]
        public string AboutMeDescription { get; set; }
        
        public Gender Gender { get; set; }

        public virtual ICollection<User> Friends { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Message> SentMessages { get; set; }

        public virtual ICollection<Message> ReceivedMessages { get; set; }

        public virtual ICollection<Message> DeletedMessages { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<Trip> SignedTrips { get; set; }
    }
}
