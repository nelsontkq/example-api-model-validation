using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelValidationExampleApi.Models;

namespace ModelValidationExampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody]PersonAddRequest request)
        {
            // This won't be hit.
            return Ok();
        }
    }
}
