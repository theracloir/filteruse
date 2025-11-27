using Microsoft.AspNetCore.Mvc;
using MyApi.Filters;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(ResourceFilter))]  // Apply Resource filter at controller level
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        [ServiceFilter(typeof(TimeActionFilter))]
        [ServiceFilter(typeof(ResultFilter))]
        public IActionResult Hello()
        {
            return Ok("Hello from API");
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            throw new Exception("Something went wrong!");
        }
    }
}
