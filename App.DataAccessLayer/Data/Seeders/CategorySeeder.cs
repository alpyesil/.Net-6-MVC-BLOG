using Microsoft.EntityFrameworkCore;

namespace App.DataAccessLayer.Data.Seeders
{
    public class CategorySeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new List<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "Life",
                    CategoryDescription = "Life",
                    CreatedAt = DateTime.Now,
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Healty",
                    CategoryDescription = "Healty",
                    CreatedAt = DateTime.Now,

                },
                new Category
                {
                    Id = 3,
                    CategoryName = "Gaming",
                    CategoryDescription = "Gaming",
                    CreatedAt = DateTime.Now,

                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Movie",
                    CategoryDescription = "Movie",
                    CreatedAt = DateTime.Now,

                }


            });
        }
    }
}