using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetResult()
        {
            return Ok(new { ID = 1, Name = "Kalem", Price = 20 });
        }
        [HttpPost]
        public IActionResult Update()
        {
            return Ok("Basarılı");
        }
    }
}
