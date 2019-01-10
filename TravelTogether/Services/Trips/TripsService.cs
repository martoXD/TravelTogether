using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.Services.Contracts;

namespace TravelTogether.Services.Trips
{
    public class TripsService : ITripsService
    {
        private readonly ApplicationDbContext db;

        public TripsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Trip> All()
        {
            IEnumerable<Trip> allTrips = new List<Trip>();
            allTrips = this.db.Trips;
            return allTrips;
        }
    }
}
