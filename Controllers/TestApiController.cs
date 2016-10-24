using Microsoft.AspNetCore.Mvc;

namespace WebApplication{
    
    public class TestApiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Ok");
        }
    }
}