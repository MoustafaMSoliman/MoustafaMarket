using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoustafaMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiExplorerSettings(IgnoreApi =true)]
    [AllowAnonymous]
    public class ErrorController : ApiController
    {
        public IActionResult Error() => Problem();
    }
}
