using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoustafaMarket.Contracts.Authentication;

namespace MoustafaMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            
            return Ok(registerRequest);
        }
    }
}
