using FutureBankingDashboard.Infrastructure;
using FutureBankingDashboard.Infrastructure.Repositories;
using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("FutureBankingDashboard.Infrastructure")
    )
);

// Services
builder.Services.AddScoped<IEconomyRepository, EconomyRepository>();
builder.Services.AddScoped<ISustainabilityRepository, SustainabilityRepository>();
builder.Services.AddScoped<IFundingRepository, FundingRepository>();
builder.Services.AddScoped<IRecommendationRepository, RecommendationRepository>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// SEEDING + MIGRATIONS 
//using (var scope = app.Services.CreateScope())
//{
    //var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    //db.Database.Migrate();      // Kør migrations
   //DataSeeder.Seed(db);        // Indsæt mock-data
//}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
