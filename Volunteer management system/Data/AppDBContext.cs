using Microsoft.EntityFrameworkCore;
using Volunteer_management_system.Models;

namespace Volunteer_management_system.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        //protected override void onModelCreating(ModelBuilder modelBuilder)
        //{
          //  base.OnModelCreating(modelBuilder);
       // }
       public DbSet<Users> Users { get; set; }
        public DbSet<Opportunities> Opportunities { get; set; }
        public DbSet<Applications> Applications { get; set; }


    }
}
