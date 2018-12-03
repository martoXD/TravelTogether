using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.Models.enums;
using TravelTogether.ViewModels.Account;

namespace TravelTogether.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ILogger<AccountController> logger;
        private readonly ApplicationDbContext dbContext;

        public AccountController(SignInManager<IdentityUser> signInManager,
            ILogger<AccountController> logger,
            ApplicationDbContext dbContext)
        {
            this.signInManager = signInManager;
            this.dbContext = dbContext;
            this.logger = logger;
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

            this.signInManager.SignInAsync(user, false).Wait();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterInputModel inputModel)
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
    }
}