using GymSystem.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSystem.Api.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options){}
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Plan> Plans { get; set; }
    }
}
