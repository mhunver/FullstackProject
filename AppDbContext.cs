using Microsoft.EntityFrameworkCore;
using FitnessApp.Models;

namespace FitnessApp.Data
{

    //dveri bağlantısı DBxonetxt tanımladım 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Member> Members { get; set; }
    }
}
