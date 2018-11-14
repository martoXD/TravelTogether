﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelTogether.Data.Configurations;
using TravelTogether.Models;

namespace TravelTogether.Data
{
    public class ApplicationDbContext : IdentityDbContext<TtUser>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripUser> TripUsers { get; set; }
        public DbSet<UserFriend> UserFriends { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Roles.Add(new IdentityRole("Admin"));
            this.Roles.Add(new IdentityRole("User"));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new ImageConfig());
            modelBuilder.ApplyConfiguration(new MessageConfig());
            modelBuilder.ApplyConfiguration(new PostConfig());
            modelBuilder.ApplyConfiguration(new TripConfig());
            modelBuilder.ApplyConfiguration(new TripUserConfig());
            modelBuilder.ApplyConfiguration(new TtUserConfig());
            modelBuilder.ApplyConfiguration(new UserFriendConfig());
        }
    }
}
