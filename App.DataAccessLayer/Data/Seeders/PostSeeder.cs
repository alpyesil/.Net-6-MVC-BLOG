using Microsoft.EntityFrameworkCore;

namespace App.DataAccessLayer.Data.Seeders
{
    public class PostSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Selam bu bir deneme Post'tur",
                    Content = "Lorem ipsum Sed eiusmod esse aliqua sed incididunt aliqua incididunt mollit id et sit proident dolor nulla sed commodo est ad minim elit reprehenderit nisi officia aute incididunt velit sint in aliqua...",
                    UserId = 1,
                    Media = "https://cdn.discordapp.com/attachments/916029512884563999/952635211320012880/cookies-400.jpg",
                    CreatedAt = DateTime.Now,
                },
                new Post
                {
                    Id = 2,
                    Title = "Selam bu bir deneme Post'tur",
                    Content = "Lorem ipsum Sed eiusmod esse aliqua sed incididunt aliqua incididunt mollit id et sit proident dolor nulla sed commodo est ad minim elit reprehenderit nisi officia aute incididunt velit sint in aliqua...",
                    UserId = 1,
                    Media = "https://cdn.discordapp.com/attachments/916029512884563999/952645698963271760/beetle-400.jpg",
                    CreatedAt = DateTime.Now,
                },
                new Post
                {
                    Id = 3,
                    Title = "Selam bu bir deneme Post'tur",
                    Content = "Lorem ipsum Sed eiusmod esse aliqua sed incididunt aliqua incididunt mollit id et sit proident dolor nulla sed commodo est ad minim elit reprehenderit nisi officia aute incididunt velit sint in aliqua...",
                    UserId = 1,
                    Media = "https://cdn.discordapp.com/attachments/916029512884563999/952948411584352306/img-lg-1.jpg",
                    CreatedAt = DateTime.Now,
                },


            });
        }


    }
}