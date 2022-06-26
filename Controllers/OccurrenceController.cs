using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace OccurrenceOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class OccurrenceController : ControllerBase
    {

        [HttpGet("occurrence/find")]
        public async Task<IActionResult> GetOccurrence(string email, string password)
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
        [HttpPost("occurrence/create")]
        public async Task<IActionResult> PostOccurrence([FromBody] Occurrence Occurrence)
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
        [HttpPatch("occurrence/create")]
        public async Task<IActionResult> PatchOccurrence([FromBody] Occurrence Occurrence)
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
        [HttpDelete("occurrence/delete")]
        public async Task<IActionResult> DeleteOccurrence(string email)
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

