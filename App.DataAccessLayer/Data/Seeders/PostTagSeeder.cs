using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccessLayer.Data.Seeders
{
    public class PostTagSeeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasData(new List<PostTag>
            {
                new PostTag
                {
                    Id = 1,
                    PostId = 1,
                    Name = "orci",
                },
                new PostTag
                {
                    Id = 2,
                    PostId = 1,
                    Name = "lectus",
                },
                new PostTag
                {
                    Id = 3,
                    PostId = 1,
                    Name = "varius",
                },
            });
        }
    }
}
