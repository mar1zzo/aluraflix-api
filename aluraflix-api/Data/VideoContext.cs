using System;
using aluraflix_api.Models;
using Microsoft.EntityFrameworkCore;

namespace aluraflix_api.Data
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> opt) : base(opt)
        {
        }

        public DbSet<Video> Videos { get; set; }
    }
}
