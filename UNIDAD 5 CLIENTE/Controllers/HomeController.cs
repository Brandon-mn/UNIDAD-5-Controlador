using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Produces("application/xml", "application/json")] // Specifies that the service produces XML
        public ActionResult<string> GetMessage()
        {
            // Creates an anonymous object with the message
            var xmlResponse = new { Message = "hola" };

            // Returns an OkObjectResult with the anonymous object
            return Ok(xmlResponse);
        }
    }
}
