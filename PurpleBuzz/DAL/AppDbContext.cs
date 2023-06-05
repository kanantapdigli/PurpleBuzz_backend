using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AboutIntroComponent> AboutIntroComponents { get; set; }
        public DbSet<WhyYouChoose> WhyYouChooses { get; set; }

        public DbSet<Our> Ours { get; set; }
    }
}
