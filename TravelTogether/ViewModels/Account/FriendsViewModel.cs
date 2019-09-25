using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTogether.ViewModels.Account
{
    public class FriendsViewModel
    {
        public string Id { get; set; }

        public int? ProfileImageId { get; set; }

        public string ProfileImageSrc { get; set; }

        public string DefaultImageSrc { get; set; }

        public string UserName { get; set; }
    }
}
