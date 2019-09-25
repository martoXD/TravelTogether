using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;
using TravelTogether.Models.enums;

namespace TravelTogether.ViewModels.Account
{
    public class MyProfileViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Username field is required!")]
        [StringLength(20, ErrorMessage = "Maximum length 20 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First name field is required!")]
        [StringLength(50, ErrorMessage = "Maximum length 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name field is required!")]
        [StringLength(50, ErrorMessage = "Maximum length 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Country field is required!")]
        [StringLength(50, ErrorMessage = "Maximum length 50 characters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "City field is required!")]
        [StringLength(50, ErrorMessage = "Maximum length 20 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Age field is required!")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(100, ErrorMessage = "Please insert maximum 100 characters")]
        public string AboutMeDescription { get; set; }

        [Required(ErrorMessage = "Gender field is required!")]
        public Gender Gender { get; set; }

        public int? ProfileImageId { get; set; }

        public string ProfileImageSrc { get; set; }

        public virtual ICollection<Image> Images { get; set; } = new List<Image>();
    }
}
