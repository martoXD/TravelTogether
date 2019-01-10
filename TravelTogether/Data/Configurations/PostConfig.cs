using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> postBuilder)
        {
            //postBuilder.HasOne<Image>()
            //   .WithOne(i => i.Post)
            //   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
