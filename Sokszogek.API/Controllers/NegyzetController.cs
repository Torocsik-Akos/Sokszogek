using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sokszogek.Models;

namespace Sokszogek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegyzetController : ControllerBase
    {
        [Route("Kerulet")]
        public double Kerulet(double OldalA)
        {
            Negyzet negyzet = new(OldalA);
            return negyzet.Kerulet();
        }

        [Route("Terulet")]
        public double Terulet(double OldalA)
        {
            return 0;
        }
    }
}
