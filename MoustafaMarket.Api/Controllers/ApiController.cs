﻿using ErrorOr;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoustafaMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        protected IActionResult Problem(List<Error> errors)
        {
            HttpContext.Items["errors"]=errors;
            var firstError = errors[0];
            var statusCode = firstError.Type switch { 
              ErrorType.NotFound =>StatusCodes.Status404NotFound,
              ErrorType.Validation=>StatusCodes.Status400BadRequest,
              ErrorType.Conflict=>StatusCodes.Status409Conflict,
              _=>StatusCodes.Status500InternalServerError
            };
            return Problem(statusCode: statusCode, title: firstError.Description);
        }
    }
}
