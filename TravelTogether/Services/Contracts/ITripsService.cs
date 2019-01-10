using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Models;

namespace TravelTogether.Services.Contracts
{
    public interface ITripsService
    {
        IEnumerable<Trip> All();
    }
}
