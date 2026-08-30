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

        public DbSet<EconomyModel> Economy { get; set; }
        public DbSet<SustainabilityModel> Sustainability { get; set; }
        public DbSet<FundingModel> Funding { get; set; }
        public DbSet<RecommendationModel> Recommendations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EconomyModel>().ToTable("Economy");
            modelBuilder.Entity<SustainabilityModel>().ToTable("Sustainability");
            modelBuilder.Entity<FundingModel>().ToTable("Funding");
            modelBuilder.Entity<RecommendationModel>().ToTable("Recommendations");

            // SEED DATA

            modelBuilder.Entity<EconomyModel>().HasData(
                new EconomyModel { Id = 1, Income = 120000, Expenses = 80000, Balance = 40000, CompanyId = 1 },
                new EconomyModel { Id = 2, Income = 130000, Expenses = 85000, Balance = 45000, CompanyId = 1 },
                new EconomyModel { Id = 3, Income = 125000, Expenses = 82000, Balance = 43000, CompanyId = 1 },
                new EconomyModel { Id = 4, Income = 140000, Expenses = 90000, Balance = 50000, CompanyId = 1 },
                new EconomyModel { Id = 5, Income = 150000, Expenses = 95000, Balance = 55000, CompanyId = 1 }
            );

            modelBuilder.Entity<SustainabilityModel>().HasData(
                new SustainabilityModel { Id = 1, Co2Score = "D", MonthlyEmission = 1400, GreenEnergiPercentage = 35, CompanyId = 1 },
                new SustainabilityModel { Id = 2, Co2Score = "C", MonthlyEmission = 1350, GreenEnergiPercentage = 38, CompanyId = 1 },
                new SustainabilityModel { Id = 3, Co2Score = "C", MonthlyEmission = 1300, GreenEnergiPercentage = 40, CompanyId = 1 },
                new SustainabilityModel { Id = 4, Co2Score = "B", MonthlyEmission = 1250, GreenEnergiPercentage = 43, CompanyId = 1 },
                new SustainabilityModel { Id = 5, Co2Score = "B", MonthlyEmission = 1200, GreenEnergiPercentage = 45, CompanyId = 1 }
            );

            modelBuilder.Entity<FundingModel>().HasData(
                new FundingModel
                {
                    Id = 1,
                    Title = "Grøn Omstillingspulje",
                    Description = "Støtte til virksomheder der reducerer CO2‑udledning.",
                    ApplicationUrl = "https://example.com/omstillingspulje",
                    RequiredCo2Score = "C"
                },
                new FundingModel
                {
                    Id = 2,
                    Title = "Energiforbedringsstøtte",
                    Description = "Tilskud til energieffektive løsninger.",
                    ApplicationUrl = "https://example.com/energi",
                    RequiredCo2Score = "B"
                },
                new FundingModel
                {
                    Id = 3,
                    Title = "Digital Grøn Innovation",
                    Description = "Funding til digitale grønne projekter.",
                    ApplicationUrl = "https://example.com/digital",
                    RequiredCo2Score = "B"
                },
                new FundingModel
                {
                    Id = 4,
                    Title = "SMV Grøn",
                    Description = "Støtte til små og mellemstore virksomheder.",
                    ApplicationUrl = "https://example.com/smv",
                    RequiredCo2Score = "D"
                },
                new FundingModel
                {
                    Id = 5,
                    Title = "EU KlimaFond",
                    Description = "EU‑tilskud til klimaprojekter.",
                    ApplicationUrl = "https://example.com/eu",
                    RequiredCo2Score = "A"
                }
            );

            modelBuilder.Entity<RecommendationModel>().HasData(
                new RecommendationModel { Id = 1, Text = "Reducer energiforbruget i produktionen.", Priority = 1, CompanyId = 1 },
                new RecommendationModel { Id = 2, Text = "Skift til grønne leverandører.", Priority = 2, CompanyId = 1 },
                new RecommendationModel { Id = 3, Text = "Invester i solceller.", Priority = 3, CompanyId = 1 },
                new RecommendationModel { Id = 4, Text = "Optimer transportlogistik.", Priority = 2, CompanyId = 1 },
                new RecommendationModel { Id = 5, Text = "Implementér CO2‑overvågning.", Priority = 1, CompanyId = 1 }
            );
        }
    }
}
