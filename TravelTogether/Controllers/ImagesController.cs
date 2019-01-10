using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelTogether.Data;

namespace TravelTogether.Controllers
{
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ImagesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Remove(int image_Id, string user_Id)
        {
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == user_Id);
            var image = this.dbContext.Images.FirstOrDefault(img => img.Id == image_Id);

            if(user.ProfileImageSrc == image.ImageSource && user.ProfileImageId == image.Id)
            {
                user.ProfileImageId = null;
                user.ProfileImageSrc = null;
            }

            user.Images.Remove(image);
            this.dbContext.Images.Remove(image);
            this.dbContext.Update(user);
            this.dbContext.SaveChanges();

            return Redirect($"/Account/Edit?id={user.Id}");
        }
    }
}