using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TravelTogether.Models;

namespace TravelTogether.Data.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> commentBuilder)
        {
            //commentBuilder.HasOne<Post>()
            //  .WithMany(p => p.Comments)
            //  .OnDelete(DeleteBehavior.Restrict);           
        }
    }
}
