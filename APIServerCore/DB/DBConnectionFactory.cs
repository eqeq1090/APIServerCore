using APIServerCore.Models;
using Microsoft.EntityFrameworkCore;

namespace APIServerCore.DB
{
    public class DBConnectionFactory : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DBConnectionFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySQL(connectionString!);
        }

        public DbSet<Test> Tests { get; set; }
    }
}
