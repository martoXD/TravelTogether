using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class LikeConfig : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> likeBuilder)
        {
            likeBuilder.HasOne<TtUser>(l => l.TtUser)
               .WithMany(tu => tu.Likes)
               .HasForeignKey("TtUserId")
               .OnDelete(DeleteBehavior.Restrict);

            likeBuilder.HasOne<Post>(l => l.Post)
              .WithMany(p => p.Likes)
              .HasForeignKey("PostId")
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
