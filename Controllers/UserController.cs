using BusOcurrenciesAPI.Business;
using BusOcurrenciesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BusOcurrenciesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataAccess dataAccess;
        public UserController(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet("user/login")]
        public async Task<IActionResult> UserLoginAsync(string email, string password)
        {
            try
            {

                var result = await dataAccess.FindUserByLogin(email, password);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("user/find")]
        public async Task<IActionResult> FindUserByIdAsync(string userId)
        {
            try
            {

                User? result = await dataAccess.FindUserById(userId);
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPost("user/create")]
        public async Task<IActionResult> PostUserAsync([FromBody] User user)
        {
            try
            {
                var result = await dataAccess.CreateUserAsync(user);
                return Ok(true);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpDelete("user/delete")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            try
            {
                var result = await dataAccess.DeleteUserById(userId);

                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPatch("user/update")]
        public async Task<IActionResult> UpdateUser(string userId, User newUser)
        {
            try
            {
                var result = await dataAccess.UpdateUser(userId, newUser);

                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
