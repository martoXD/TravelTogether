using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelTogether.ViewModels.Account;

namespace TravelTogether.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Login(LoginInputModel model)
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Register(string returnUrl = null)
        {
            var returnUrlParsed = returnUrl ?? Url.Content("~/");

            HttpContext.SignOutAsync(IdentityConstants.ExternalScheme).GetAwaiter().GetResult();

            this.TempData["ReturnUrl"] = returnUrlParsed;

            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterInputModel model)
        {
            string returnUrl = this.TempData["ReturnUrl"]?.ToString();

            return this.Redirect(returnUrl);
        }
    }
}