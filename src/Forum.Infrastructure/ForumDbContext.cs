using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Forum.Infrastructure
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}