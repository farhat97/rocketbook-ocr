using Microsoft.AspNetCore.Mvc;

namespace rocketbook_ocr.Controllers
{
    [Route("api")]
    [ApiController]
    public class MainController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult TestEndpoint()
        {
            return Ok("Test endpoint");
        }

    }

}
