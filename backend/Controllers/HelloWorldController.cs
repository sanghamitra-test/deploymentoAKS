using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
	        [HttpGet]
	        public IActionResult Get()
	        {
	            return Ok("Welcome to Hello World");
	        }
	    }

}
