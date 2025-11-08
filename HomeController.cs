using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("rumah")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello, welocme to my API!";
        }

        [HttpGet("hai")]

        public string Hai([FromQuery] string nama)

        {
            return "Hello, " + nama + "!";
        }
    }
}