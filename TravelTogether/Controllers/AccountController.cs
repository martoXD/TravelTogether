using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Data;
using TravelTogether.Models;
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
        private readonly IMapper mapper;

        public AccountController(SignInManager<IdentityUser> signInManager,
            ILogger<AccountController> logger,
            ApplicationDbContext dbContext,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper)
        {
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.logger = logger;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel inputModel)
        {
            if (inputModel.UserName == null || inputModel.Password == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var user = (TtUser)this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.UserName == inputModel.UserName);
            
            if (user != null)
            {
                this.signInManager.SignInAsync(user, false).Wait();
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

            var userProfileViewModel = this.mapper.Map<MyProfileViewModel>(user);

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

        [HttpGet]
        [Authorize]
        public IActionResult Edit(string id)
        {
            var user = (TtUser)this.signInManager.UserManager.Users
                .FirstOrDefault(u => u.Id == id);

            var userProfileViewModel = this.mapper.Map<MyProfileViewModel>(user);

            foreach (var image in user.Images)
            {
                userProfileViewModel.Images.Add(image);
            }

            return this.View(userProfileViewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(MyProfileViewModel inputModel)
        {
            var user = (TtUser)this.signInManager.UserManager.Users
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

                dbContext.Update(user);
                dbContext.SaveChanges();

                return Redirect($"/Account/MyProfile?id={user.Id}");
            }
            else
            {
                return this.View(inputModel);
            }
        }
    }
}