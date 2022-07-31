using BusOcurrenciesAPI.Business;
using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
       private readonly IDataAccess dataAccess;
        public CompanyController(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet("company/find")]
        public async Task<IActionResult> GetCompanyAsync(string id)
        {
            try
            {
                var result = await dataAccess.FindCompanyById(id);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost("company/create")]
        public async Task<IActionResult> PostCompanyAsync([FromBody] Company company)
        {
            try
            {
                var result = await dataAccess.CreateCompanyAsync(company);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("company/delete")]
        public async Task<IActionResult> DeleteCompanyAsync(string id)
        {
            try
            {
                var result = await dataAccess.DeleteCompanyById(id);

                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPatch("company/edit")]
        public async Task<IActionResult> UpdateCompanyAsync(string id, Company company)
        {
            try
            {
                var result = await dataAccess.UpdateCompany(id, company);

                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
