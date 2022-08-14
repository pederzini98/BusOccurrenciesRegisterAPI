using BusOcurrenciesAPI.Business;
using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace OccurrenceOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class OccurrenceController : ControllerBase
    {
        private readonly IDataAccess dataAccess;
        public OccurrenceController(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        [HttpGet("occurrence/find")]
        public async Task<IActionResult> GetOccurrenceAsync(string id)
        {
            try
            {
                return Ok(await dataAccess.GetOccurrence(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("occurrence/user/find")]
        public async Task<IActionResult> GetUserOccurrencesAsync(string id)
        {
            try
            {
                return Ok(await dataAccess.GetAllOccurrenceOfUser(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("occurrence/company/find")]
        public async Task<IActionResult> GetCompanyOccurrencesAsync(string id)
        {
            try
            {
                return Ok(await dataAccess.GetAllOccurrenceOfCompany(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost("occurrence/create")]
        public async Task<IActionResult> PostOccurrenceAsync([FromBody] Occurrence occurrence)
        {
            try
            {
                occurrence.CreationDate = DateTime.UtcNow.ToLocalTime();
                return Ok(await dataAccess.CreateOccurrence(occurrence));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPatch("occurrence/edit")]
        public async Task<IActionResult> PatchOccurrenceAsync(string id, Occurrence occurrence)
        {
            try
            {
                return Ok(await dataAccess.EditOccurrence(id, occurrence));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("occurrence/deletesss")]
        public async Task<IActionResult> DeleteOccurrenceAsync (string id)
        {
            try
            {
                return Ok(await dataAccess.DeleteOccurrence(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}

