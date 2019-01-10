using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class TtUserConfig : IEntityTypeConfiguration<TtUser>
    {
        public void Configure(EntityTypeBuilder<TtUser> userBuilder)
        {
            userBuilder.HasMany<Message>(u => u.SentMessages)
                .WithOne(m => m.Sender)
                .OnDelete(DeleteBehavior.Restrict);

            userBuilder.HasMany<Message>(u => u.ReceivedMessages)
                .WithOne(m => m.Receiver)
                .OnDelete(DeleteBehavior.Restrict);

            userBuilder.HasMany<FriendShip>(f => f.MainUserFriends)
                .WithOne(fsh => fsh.TtUser)
                .OnDelete(DeleteBehavior.Restrict);

            userBuilder.HasMany<FriendShip>(f => f.Friends)
                .WithOne(fsh => fsh.Friend)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
