using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.ViewModels.Account;
using TravelTogether.ViewModels.Trips;

namespace TravelTogether.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<TtUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<AccountController> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<TtUser> userManager;
        private readonly IMapper mapper;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IPasswordHasher<TtUser> passwordHasher = new PasswordHasher<TtUser>();

        public AccountController(SignInManager<TtUser> signInManager,
            ILogger<AccountController> logger,
            ApplicationDbContext dbContext,
            UserManager<TtUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            IHostingEnvironment hostingEnvironment,
            IPasswordHasher<TtUser> passwordHasher)
        {
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.logger = logger;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel inputModel)
        {
            if (inputModel.UserName == null || inputModel.Password == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.UserName == inputModel.UserName);

            if (user != null)
            {
                if (passwordHasher.VerifyHashedPassword(user, user.PasswordHash, inputModel.Password) == PasswordVerificationResult.Success)
                {
                    this.signInManager.SignInAsync(user, false).Wait();
                }
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterInputModel inputModel)
        {
            if (ModelState.IsValid)
            {
                var user = this.mapper.Map<TtUser>(inputModel);

                string imgPath = @"D:/softuni/TravelTogether/TravelTogether/wwwroot/images/default_icon.jpg";

                byte[] byteData = System.IO.File.ReadAllBytes(imgPath);

                string imgBase64Data = Convert.ToBase64String(byteData);
                string imgDataURL = string.Format("data:image/png;base64,{0}", imgBase64Data);

                user.DefaultImageSrc = imgDataURL;

                var result = this.signInManager.UserManager.CreateAsync(user, inputModel.Password).Result;

                if (result.Succeeded)
                {
                    if (!this.dbContext.Users.Any())
                    {
                        var roleName = "Admin";
                        var roleExists = await roleManager.RoleExistsAsync(roleName);
                        if (roleExists)
                        {
                            this.userManager.AddToRoleAsync(user, roleName).Wait();
                        }
                    }

                    this.signInManager.SignInAsync(user, false).Wait();
                    return this.RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return this.View(inputModel);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public IActionResult MyProfile(string id)
        {
            var user = this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.Id == id);

            var userProfileViewModel = this.mapper.Map<MyProfileViewModel>(user);
            var profileImage = this.dbContext.Images
                .FirstOrDefault(img => user.ProfileImageId == img.Id);

            if (profileImage != null)
            {
                string imageBase64 = Convert.ToBase64String(profileImage.ImageContent);
                string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                userProfileViewModel.ProfileImageSrc = imageSrc;
                userProfileViewModel.ProfileImageId = profileImage.Id;
            }

            var images = this.dbContext.Images.Where(img => img.TtUserId == user.Id).ToArray();

            userProfileViewModel.Images = new List<Image>();

            foreach (var image in images)
            {
                string imageBase64 = Convert.ToBase64String(image.ImageContent);
                string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                image.ImageSource = imageSrc;
                userProfileViewModel.Images.Add(image);
            }

            return this.View(userProfileViewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Logout()
        {
            this.signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Edit(string id)
        {
            var user = this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.Id == id);

            var userImages = this.dbContext.Images.Where(img => img.TtUserId == user.Id).ToArray();

            var userProfileViewModel = this.mapper.Map<MyProfileViewModel>(user);
            var profileImage = this.dbContext.Images
                .FirstOrDefault(img => img.Id == user.ProfileImageId);

            if (profileImage != null)
            {
                string imageBase64 = Convert.ToBase64String(profileImage.ImageContent);
                string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                userProfileViewModel.ProfileImageSrc = imageSrc;
                userProfileViewModel.ProfileImageId = profileImage.Id;
            }

            userProfileViewModel.Images = new List<Image>();

            foreach (var image in userImages)
            {
                string imageBase64 = Convert.ToBase64String(image.ImageContent);
                string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                image.ImageSource = imageSrc;
                userProfileViewModel.Images.Add(image);
            }

            return this.View(userProfileViewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(MyProfileViewModel inputModel, IFormFile profileImage, IFormFile imageInput)
        {
            var user = this.signInManager.UserManager.Users
               .FirstOrDefault(u => u.Id == inputModel.Id);

            if (ModelState.IsValid)
            {
                user.AboutMeDescription = inputModel.AboutMeDescription;
                user.UserName = inputModel.UserName;
                user.FirstName = inputModel.FirstName;
                user.LastName = inputModel.LastName;
                user.Country = inputModel.Country;
                user.City = inputModel.City;
                user.Age = inputModel.Age;
                user.Gender = user.Gender;
                if (profileImage != null)
                {
                    MemoryStream ms = new MemoryStream();
                    profileImage.OpenReadStream().CopyTo(ms);

                    var image = new Image()
                    {
                        ImageContent = ms.ToArray(),
                        TtUser = user,
                        TtUserId = user.Id
                    };
                    string imageBase64 = Convert.ToBase64String(image.ImageContent);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                    image.ImageSource = imageSrc;
                    this.dbContext.Images.Add(image);
                    this.dbContext.SaveChanges();

                    user.ProfileImageId = image.Id;
                    user.ProfileImageSrc = image.ImageSource;
                    user.Images.Add(image);

                    this.dbContext.Update(user);

                    this.dbContext.Entry(user).State = EntityState.Modified;
                }
                if (imageInput != null)
                {
                    MemoryStream ms = new MemoryStream();
                    imageInput.OpenReadStream().CopyTo(ms);

                    var image = new Image()
                    {
                        ImageContent = ms.ToArray(),
                        TtUser = user,
                        TtUserId = user.Id
                    };

                    string imageBase64 = Convert.ToBase64String(image.ImageContent);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                    image.ImageSource = imageSrc;

                    user.Images.Add(image);

                    this.dbContext.Images.Add(image);

                    this.dbContext.Entry(user).State = EntityState.Modified;
                }

                this.dbContext.Update(user);
                this.dbContext.SaveChanges();

                return Redirect($"/Account/MyProfile?id={user.Id}");
            }
            else
            {
                var imageProfile = this.dbContext.Images.FirstOrDefault(img => img.Id == user.ProfileImageId);

                if (imageProfile != null)
                {
                    string imageBase64 = Convert.ToBase64String(imageProfile.ImageContent);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                    inputModel.ProfileImageId = imageProfile.Id;
                    inputModel.ProfileImageSrc = imageSrc;
                }
                else
                {
                    string imgPath = @"D:/softuni/TravelTogether/TravelTogether/wwwroot/images/default_icon.jpg";

                    byte[] byteData = System.IO.File.ReadAllBytes(imgPath);

                    string imgBase64Data = Convert.ToBase64String(byteData);
                    string imgDataURL = string.Format("data:image/png;base64,{0}", imgBase64Data);

                    inputModel.ProfileImageSrc = imgDataURL;
                }

                var userImages = this.dbContext.Images.Where(img => img.TtUserId == user.Id).ToArray();
                inputModel.Images = new List<Image>();

                foreach (var image in userImages)
                {
                    string imageBase64 = Convert.ToBase64String(image.ImageContent);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);

                    image.ImageSource = imageSrc;
                    inputModel.Images.Add(image);
                }

                return this.View(inputModel);
            }
        }

        [HttpGet]
        public IActionResult Profile(string id)
        {
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == id);

            var userProfileViewModel = this.mapper.Map<UserProfileViewModel>(user);

            return this.View(userProfileViewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddFriend(string memberId, string currentUserId)
        {
            var currentUser = this.dbContext.Users.FirstOrDefault(u => u.Id == currentUserId);
            var member = this.dbContext.Users.FirstOrDefault(u => u.Id == memberId);

            var friendShip = new FriendShip()
            {
                TtUser = currentUser,
                Friend = member
            };

            currentUser.MainUserFriends.Add(friendShip);
            member.Friends.Add(friendShip);
            this.dbContext.FriendShips.Add(friendShip);
            this.dbContext.SaveChanges();

            return Redirect($"/Home/Members?id={currentUser.Id}");
        }

        [HttpPost]
        [Authorize]
        public IActionResult RemoveFriend(string memberId, string currentUserId)
        {
            var currentUser = this.dbContext.Users.FirstOrDefault(u => u.Id == currentUserId);
            var member = this.dbContext.Users.FirstOrDefault(u => u.Id == memberId);

            var friendShip = this.dbContext.FriendShips.Where(fsh => fsh.TtUser == currentUser
                                                                && fsh.Friend == member).FirstOrDefault();

            if (friendShip != null)
            {
                currentUser.MainUserFriends.Remove(friendShip);
                member.Friends.Remove(friendShip);
                this.dbContext.FriendShips.Remove(friendShip);
                this.dbContext.SaveChanges();
            }

            return Redirect($"/Home/Members?id={currentUser.Id}");
        }

        [HttpGet]
        [Authorize]
        //[Route("trips")]
        public IActionResult MyTrips(string id)
        {
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == id);

            var myTripsViewModels = new List<MyTripsViewModel>();

            foreach (var tripUser in user.SignedTrips)
            {
                var myTripViewModel = this.mapper.Map<MyTripsViewModel>(tripUser.Trip);
                myTripsViewModels.Add(myTripViewModel);
            }

            return this.View(myTripsViewModels);
        }
    }
}