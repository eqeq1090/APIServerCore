using APIServerCore.Models;
using Microsoft.EntityFrameworkCore;

namespace APIServerCore.DB
{
    public class TestContext : DbContext
    {
       public virtual DbSet<Test> Tests { get; set; }

        public TestContext(DbContextOptions<TestContext> options)
        : base(options)
        {
        }
    }

}