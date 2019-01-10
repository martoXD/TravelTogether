using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class TripUserConfig : IEntityTypeConfiguration<TripUser>
    {
        public void Configure(EntityTypeBuilder<TripUser> tpBuilder)
        {
            tpBuilder.HasKey(tu => new { tu.TripId, tu.TtUserId });

            tpBuilder.HasOne<Trip>(tp => tp.Trip)
                .WithMany(t => t.SignedUsers)
                .OnDelete(DeleteBehavior.Restrict);

            tpBuilder.HasOne<TtUser>(tp => tp.TtUser)
               .WithMany(u => u.SignedTrips)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
