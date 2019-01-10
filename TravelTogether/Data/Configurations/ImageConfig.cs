using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> imageBuilder)
        {
            //imageBuilder.HasOne<Trip>()
            // .WithMany(t => t.Images)
            // .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
