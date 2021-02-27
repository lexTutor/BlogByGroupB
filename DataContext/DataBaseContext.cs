using KingdomBlog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataContext
{
    public class DataBaseContext : IdentityDbContext
    {
        public DbSet<BlogUser> BlogUser { get; set; }

        public DbSet<Post> Post {get; set;}

        public DbSet<UserActivity> UserActivities { get; set; }

        public DbSet<UserActivityType> UserActivityTypes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<PostActivity> PostActivities { get; set; }

        public DbSet<PostActivityType> PostActivityTypes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PostCategories> PostCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PostCategories>().HasKey(key => new { key.CategoryId, key.PostId });
            builder.Entity<PostCategories>().HasOne(postCartegory => postCartegory.Post).WithMany(postCategory => postCategory.PostCategories);
            builder.Entity<PostCategories>().HasOne(postCategory => postCategory.Category).WithMany(postCategory => postCategory.PostCategories);
        }
    }
}
