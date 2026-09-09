using FutureBankingDashboard.Infrastructure;
using FutureBankingDashboard.Infrastructure.Repositories;
using FutureBankingDashboard.Library.Interfaces;
using FutureBankingDashboard.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// DbContext + Retry on Failure + MigrationsAssembly
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions =>
        {
            sqlOptions.MigrationsAssembly("FutureBankingDashboard.Infrastructure");
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorNumbersToAdd: null
            );
        }
    )
);

// Repositories
builder.Services.AddScoped<IEconomyRepository, EconomyRepository>();
builder.Services.AddScoped<ISustainabilityRepository, SustainabilityRepository>();
builder.Services.AddScoped<IFundingRepository, FundingRepository>();
builder.Services.AddScoped<IRecommendationRepository, RecommendationRepository>();

// Services
builder.Services.AddScoped<IEconomyService, EconomyService>();
builder.Services.AddScoped<ISustainabilityService, SustainabilityService>();
builder.Services.AddScoped<IFundingService, FundingService>();
builder.Services.AddScoped<IRecommendationService, RecommendationService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

