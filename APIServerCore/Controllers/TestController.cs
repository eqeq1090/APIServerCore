using APIServerCore.Models;
using APIServerCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIServerCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly TestService _service;
        public TestController(TestService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<List<Test>> GetAll()
        {
            return _service.GetTests();
        }

    }
}
