using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelTogether.Models;
using TravelTogether.Models.enums;
using TravelTogether.ViewModels.Account;

namespace TravelTogether.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel inputModel)
        {
            var user = this.signInManager.UserManager.Users.FirstOrDefault(u => u.UserName == inputModel.Username);
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

            if (signInManager.UserManager.Users.Count() == 1)
            {
                var roleResult = this.signInManager.UserManager.AddToRoleAsync(user, "Administrator").Result;

                if (roleResult.Errors.Any())
                {
                    return this.View();
                }
            }

            if (result.Succeeded)
            {
                this.signInManager.SignInAsync(user, false).Wait();
                return this.RedirectToAction("Index", "Home");
            }
            
            return this.View();
        }
    }
}