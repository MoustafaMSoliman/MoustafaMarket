using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoustafaMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public Task<IActionResult> Register()
        {

        }
    }
}
