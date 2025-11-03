using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectArgoCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("This is a test endpoint from ATestController.");
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Post");
        }
    }
}
