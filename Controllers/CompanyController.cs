using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpGet("company/find")]
        public async Task<IActionResult> GetCompany(string email, string password)
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
        [HttpPost("company/create")]
        public async Task<IActionResult> PostCompany([FromBody] Company company)
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
        [HttpDelete("company/delete")]
        public async Task<IActionResult> DeleteCompany(string email)
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
