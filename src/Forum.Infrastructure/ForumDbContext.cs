using Forum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
