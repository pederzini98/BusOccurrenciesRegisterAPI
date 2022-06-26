using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet("user/find")]
        public async Task<IActionResult> GetUser(string email, string password)
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
        [HttpPost("user/create")]
        public async Task<IActionResult> PostUser([FromBody] User user)
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
        [HttpDelete("user/delete")]
        public async Task<IActionResult> DeleteUser(string email)
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
