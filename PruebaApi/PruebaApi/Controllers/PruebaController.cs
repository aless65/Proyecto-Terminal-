using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet]
        public ActionResult TheBest(int num1, int num2)
        {
            try
            {
                int variable = num1 + num2;
                return Ok(variable);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
