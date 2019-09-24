using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;

namespace TravelTogether.ViewModels.Posts
{
    public class CreatePostViewModel
    {
        public string UserId { get; set; }

        [StringLength(40)]
        public string Caption { get; set; }
        
        public IFormFile Image { get; set; }
    }
}
