using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TravelTogether.Utilities
{
    public static class Seeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            var adminRoleExists = roleManager.RoleExistsAsync("Admininstrator").Result;
            if(!adminRoleExists)
            {
                roleManager.CreateAsync(new IdentityRole("Admininstrator"));
            }
        }
    }
}
