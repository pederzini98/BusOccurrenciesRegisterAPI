using BusOcurrenciesAPI.Business;
using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IDataAccess dataAccess;
        public BusController(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet("bus/find")]
        public async Task<IActionResult> GetBusAsync(int number)
        {
            try
            {
                var result = await dataAccess.GetBus(number);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("bus/findbycompany")]
        public async Task<IActionResult> GetBusByCompanyAsync(string companyId)
        {
            try
            {
                var result = await dataAccess.FindBusByCompany(companyId);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("bus/findbystopplace")]
        public async Task<IActionResult> GetBusByStopPlaceAsync(string stopPlace)
        {
            try
            {
                var result = await dataAccess.FindBusByStopPlace(stopPlace);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost("bus/create")]
        public async Task<IActionResult> PostBusAsync([FromBody] Bus Bus)
        {
            try
            {
                var resukt = await dataAccess.CreateBus(Bus);
                return Ok(resukt);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("bus/delete")]
        public async Task<IActionResult> DeleteBus(string id)
        {
            try
            {

                return Ok(await dataAccess.DeleteBus(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
