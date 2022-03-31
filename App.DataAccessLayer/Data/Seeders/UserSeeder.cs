using Microsoft.EntityFrameworkCore;

namespace App.DataAccessLayer.Data.Seeders
{
    public class UserSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    Name = "Admin",
                    UserName = "Admin",
                    Email = "admin@gmail.com",
                    Password = "Admin",
                    CreatedAt = DateTime.Now,
                    ProfileImagePath = "https://cdn.discordapp.com/attachments/916029512884563999/949102276654538792/user.png",
                    Roles = "Admin"
                }
            });
        }
    }
}