using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class BusController : ControllerBase
    {
        [HttpGet("bus/find")]
        public async Task<IActionResult> GetBus(string email, string password)
        {
            try
            {

                return Ok(true);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost("bus/create")]
        public async Task<IActionResult> PostBus([FromBody] Bus Bus)
        {
            try
            {

                return Ok(true);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("bus/delete")]
        public async Task<IActionResult> DeleteBus(string email)
        {
            try
            {

                return Ok(true);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
