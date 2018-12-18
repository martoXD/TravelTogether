using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.ViewModels.Posts;

namespace TravelTogether.Controllers
{
    public class HomeController : Controller
    {
        private const int MAX_POSTS_PERPAGE = 12;

        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public HomeController(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var allPosts = this.dbContext.Posts
                .Include(p => p.Comments)
                .ThenInclude(c => c.Sender)
                .OrderByDescending(p => p.CreatedOn)
                .Take(MAX_POSTS_PERPAGE)
                .ToList();
                
            var allPostsViewModels = new List<AllPostsViewModel>();

            foreach (var post in allPosts)
            {
                var allPostsViewModel = this.mapper.Map<AllPostsViewModel>(post);
                allPostsViewModels.Add(allPostsViewModel);
            }

            return View(allPostsViewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
