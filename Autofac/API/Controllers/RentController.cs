using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync([FromServices] IRentApplicationService service)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Rent rent, [FromServices] IRentApplicationService service)
        {
            return Created("", null);
        }
    }
}
