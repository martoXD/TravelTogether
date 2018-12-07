using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.Models.enums;
using TravelTogether.ViewModels.Account;

namespace TravelTogether.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ILogger<AccountController> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<IdentityUser> userManager;

        public AccountController(SignInManager<IdentityUser> signInManager,
            ILogger<AccountController> logger,
            ApplicationDbContext dbContext,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.logger = logger;
            this.userManager = userManager;
            this.roleManager = roleManager;
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

            //var isMatch = userManager.CheckPasswordAsync(user, user.PasswordHash).Result;
            //if (isMatch)
            //{
            //var signInStatus = this.signInManager.PasswordSignInAsync(user, inputModel.Password, true, false);

            //if (signInStatus.IsCompletedSuccessfully)
            //{
                this.signInManager.SignInAsync(user, false).Wait();
            //}
            //}

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
                var gender = Enum.TryParse(inputModel.Gender, out Gender genderValue);
                var user = new TtUser()
                {
                    UserName = inputModel.Username,
                    PasswordHash = inputModel.Password,
                    FirstName = inputModel.FirstName,
                    LastName = inputModel.LastName,
                    Country = inputModel.Country,
                    City = inputModel.City,
                    Gender = genderValue
                };

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
            var user = (TtUser)this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.Id == id);

            var userProfileViewModel = new MyProfileViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Age = user.Age,
                AboutMeDescription = user.AboutMeDescription,
                City = user.City,
                Country = user.Country,
                Gender = user.Gender
            };

            foreach (var image in user.Images)
            {
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
    }
}