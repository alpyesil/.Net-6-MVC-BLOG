using App.DataAccessLayer.Data.Entity;
using App.DataAccessLayer.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<CategoryPost> CategoryPosts { get; set; }

        public DbSet<PostComment> PostComments { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostComment>()
                .HasOne(e => e.User)
                .WithMany(e => e.PostComments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CategoryPost>()
                .HasOne(z => z.Post)
                .WithMany(s => s.CategoryPosts)
                .HasForeignKey(s => s.PostId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CategoryPost>()
                .HasOne(z => z.Category)
                .WithMany(s => s.CategoryPosts)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);



            UserSeeder.SeedData(modelBuilder);
            PostSeeder.SeedData(modelBuilder);
            CategorySeeder.SeedData(modelBuilder);
            PostTagSeeder.SeedData(modelBuilder);
            CategoryPostSeeder.SeedData(modelBuilder);

        }
    }
}