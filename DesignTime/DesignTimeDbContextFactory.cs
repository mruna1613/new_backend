using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using new_backend.Data;
using System.IO;

namespace new_backend.DesignTime
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AttendanceContext>
    {
        public AttendanceContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<AttendanceContext>();
            var connectionString = configuration.GetConnectionString("LoginDetailsDB");
            builder.UseSqlServer(connectionString);

            return new AttendanceContext(builder.Options);
        }
    }
}
