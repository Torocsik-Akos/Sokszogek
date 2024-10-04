using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sokszogek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        // GET api/Teszt?nev=Bence
        // GET api/Teszt/Udvozles?nev=Bence
        [HttpGet]
        [Route("")]
        [Route("Udvozles")]
        public string Udvozles(string nev)
        {
            return $"Hello {nev}!";
        }
    }
}
