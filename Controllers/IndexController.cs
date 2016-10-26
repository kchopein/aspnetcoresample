using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApi
{
    [Route("/")]
    public class IndexController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            dsdsd
            return new OkObjectResult("Request processed by " + System.Environment.MachineName);
        }
    }
}
