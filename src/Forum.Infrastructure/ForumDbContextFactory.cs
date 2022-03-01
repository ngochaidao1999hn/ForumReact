using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure
{
    public class ForumDbContextFactory : IDesignTimeDbContextFactory<ForumDbContext>
    {    
        public ForumDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ForumDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-OA32JNB\\SQLEXPRESS01;Database=Forum_Db;Trusted_Connection=True;");
            return new ForumDbContext(optionsBuilder.Options);
        }
    }
}
