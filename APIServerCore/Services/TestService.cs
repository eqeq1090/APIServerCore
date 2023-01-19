using APIServerCore.DB;
using APIServerCore.Models;
using Microsoft.EntityFrameworkCore;

namespace APIServerCore.Services
{
    public class TestService: IService
    {
        private readonly TestContext _context;

        public TestService(TestContext context)
        {
            _context = context;
        }

        public List<Test> GetTests()
        {
            return _context.Tests.FromSql($"SELECT * FROM test").ToList();
        }
    }
}
