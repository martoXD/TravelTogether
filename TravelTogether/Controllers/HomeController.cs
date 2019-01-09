using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.ViewModels.Home;
using TravelTogether.ViewModels.Posts;
using X.PagedList;

namespace TravelTogether.Controllers
{
    public class HomeController : Controller
    {
        private const int MAX_ENTITIES_PERPAGE = 12;

        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public HomeController(
            ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index(int? page)
        {
            var allPosts = this.dbContext.Posts
                .Include(p => p.Comments)
                .ThenInclude(c => c.Sender)
                .OrderByDescending(p => p.CreatedOn);
            //.Take(MAX_ENTITIES_PERPAGE);

            var allPostsViewModels = new List<AllPostsViewModel>();

            foreach (var post in allPosts)
            {
                var allPostsViewModel = this.mapper.Map<AllPostsViewModel>(post);
                allPostsViewModels.Add(allPostsViewModel);
            }

            var pageNumber = page ?? 1;
            var pagedViewModels = allPostsViewModels.ToPagedList(pageNumber, MAX_ENTITIES_PERPAGE);

            return this.View(pagedViewModels);
        }

        [HttpGet]
        [Route("/Home/Members")]
        public IActionResult Members(int? page, string id)
        {
            var users = this.dbContext.Users;
            var allUsers = users
                .Where(u => u.Id != id)
                .Take(MAX_ENTITIES_PERPAGE)
                .ToList();

            var allUsersViewModels = new List<AllUsersViewModel>();

            foreach (var user in allUsers)
            {
                var allUsersViewModel = this.mapper.Map<AllUsersViewModel>(user);
                allUsersViewModels.Add(allUsersViewModel);
            }

            var pageNumber = page ?? 1;
            var pagedViewModels = allUsersViewModels.ToPagedList(pageNumber, MAX_ENTITIES_PERPAGE);

            return this.View(pagedViewModels.ToList());
        }

        [HttpGet]
        [Authorize]
        public IActionResult Search(string searchText)
        {
            var searchedPosts = new List<Post>();
            var searchedPostsViewModels = new List<AllPostsViewModel>();

            if (!string.IsNullOrEmpty(searchText))
            {
                searchedPosts = this.dbContext.Posts
                .Where(p => p.Caption.Contains(searchText) || p.TtUser.UserName.Contains(searchText))
                .ToList();

                foreach (var post in searchedPosts)
                {
                    var searchedPostsViewModel = this.mapper.Map<AllPostsViewModel>(post);
                    searchedPostsViewModels.Add(searchedPostsViewModel);
                }
            }

            return this.View("Index", searchedPostsViewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
