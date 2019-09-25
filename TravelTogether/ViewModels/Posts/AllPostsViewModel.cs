using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TravelTogether.Models;

namespace TravelTogether.ViewModels.Posts
{
    public class AllPostsViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string Caption { get; set; }

        public DateTime CreatedOn { get; set; }

        public string TtUserId { get; set; }
        public TtUser TtUser { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Like> Likes { get; set; }
    }
}
