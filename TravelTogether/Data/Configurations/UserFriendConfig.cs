using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class UserFriendConfig : IEntityTypeConfiguration<FriendShip>
    {
        public void Configure(EntityTypeBuilder<FriendShip> ufBuilder)
        {
            ufBuilder.HasKey(uf => uf.Id);
        }
    }
}
