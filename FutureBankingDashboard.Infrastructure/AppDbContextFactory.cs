using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FutureBankingDashboard.Infrastructure
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=tcp:futurebankingserver.database.windows.net,1433;Initial Catalog=FutureDB2;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

            );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

