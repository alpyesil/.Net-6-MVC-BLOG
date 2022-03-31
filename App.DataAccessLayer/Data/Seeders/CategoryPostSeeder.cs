using App.DataAccessLayer.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccessLayer.Data.Seeders
{
    public class CategoryPostSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryPost>().HasData(new List<CategoryPost>
            {
                new CategoryPost
                {
                    Id = 1,
                    CategoryId = 1,
                    PostId = 1,
                },
                new CategoryPost
                {
                    Id = 2,
                    CategoryId = 2,
                    PostId = 2,
                },
                new CategoryPost
                {
                    Id = 3,
                    CategoryId = 3,
                    PostId = 3,
                },
                new CategoryPost
                {
                    Id = 4,
                    CategoryId = 2,
                    PostId = 1,
                },
            });
        }
    }
}