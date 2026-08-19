
using FutureBankingDashboard.Library.Models;
using Microsoft.EntityFrameworkCore;
namespace FutureBankingDashboard.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets = tabeller i databasen
        public DbSet<EconomyModel> Economy { get; set; }
        public DbSet<SustainabilityModel> Sustainability { get; set; }
        public DbSet<FundingModel> Funding { get; set; }
        public DbSet<RecommendationModel> Recommendations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Valgfrit: navngiv tabellerne
            modelBuilder.Entity<EconomyModel>().ToTable("Economy");
            modelBuilder.Entity<SustainabilityModel>().ToTable("Sustainability");
            modelBuilder.Entity<FundingModel>().ToTable("Funding");
            modelBuilder.Entity<RecommendationModel>().ToTable("Recommendations");
        }
    }
}