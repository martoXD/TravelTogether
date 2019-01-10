using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.Services.Contracts;
using TravelTogether.ViewModels.Trips;

namespace TravelTogether.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripsService tripsService;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public TripsController(
            ITripsService tripsService,
            ApplicationDbContext dbContext,
            IMapper mapper)
        {
            this.tripsService = tripsService;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        [Authorize]
        public IActionResult All()
        {
            var allTrips = this.tripsService.All();

            var allTripsViewModels = new List<AllTripsViewModel>();

            foreach (var trip in allTrips)
            {
                var allTripsViewModel = this.mapper.Map<AllTripsViewModel>(trip);
                allTripsViewModels.Add(allTripsViewModel);
            }

            return View(allTripsViewModels);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(string country, string city, IFormFile inputImage, string userId)
        {
            var user = (TtUser)this.dbContext.Users.FirstOrDefault(u => u.Id == userId);
            Trip trip = null;
            Image image = null;

            if (ModelState.IsValid)
            {
                if(user != null && inputImage != null)
                {
                    MemoryStream ms = new MemoryStream();
                    inputImage.OpenReadStream().CopyTo(ms);

                    image = new Image
                    {
                        ImageContent = ms.ToArray()
                    };

                    string imageBase64 = Convert.ToBase64String(image.ImageContent);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                    image.ImageSource = imageSrc;

                    trip = new Trip
                    {
                        Country = country,
                        City = city,
                        CreatorId = user.Id,
                        Creator = user
                    };

                    image.Trip = trip;
                    trip.Images.Add(image);

                    var tripUser = new TripUser
                    {
                        TtUser = user,
                        Trip = trip
                    };

                    user.SignedTrips.Add(tripUser);
                    trip.SignedUsers.Add(tripUser);

                    this.dbContext.Images.Add(image);
                    this.dbContext.Trips.Add(trip);
                    this.dbContext.TripUsers.Add(tripUser);
                    this.dbContext.SaveChanges();
                }
            }

            return RedirectToAction("All", "Trips");
        }

        [HttpPost]
        [Authorize]
        public IActionResult Join(string userId, int tripId)
        {
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == userId);
            var trip = this.dbContext.Trips.FirstOrDefault(t => t.Id == tripId);

            var tripUser = new TripUser
            {
                TtUser = user,
                Trip = trip
            };
            user.SignedTrips.Add(tripUser);
            trip.SignedUsers.Add(tripUser);
            this.dbContext.TripUsers.Add(tripUser);
            this.dbContext.SaveChanges();

            return Redirect($"/Account/MyTrips?id={user.Id}");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Search(string searchText)
        {
            var searchedTrips = new List<Trip>();
            var searchedTripsViewModels = new List<AllTripsViewModel>();
            
            if (!string.IsNullOrEmpty(searchText))
            {
                searchedTrips = this.dbContext.Trips
                .Where(t => t.Country.Contains(searchText) || t.City.Contains(searchText))
                .ToList();

                foreach (var trip in searchedTrips)
                {
                    var searchedTripViewModel = this.mapper.Map<AllTripsViewModel>(trip);
                    searchedTripsViewModels.Add(searchedTripViewModel);
                }

                return this.View($"All", searchedTripsViewModels);
            }

            return this.RedirectToAction("All", "Trips");
        }
    }
}