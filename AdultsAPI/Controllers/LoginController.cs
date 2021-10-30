using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AdultsApi.Authentification;
using AdultsAPI.Data;
using AdultsApi.Models;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AdultsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private IUserService UserService;
        
        [Route("/Login/UserLogin")]  
        [HttpPost]
        public async Task<ActionResult<User>> Login([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var validatedUser = UserService.ValidateUser(user.UserName, user.Password);
                return Ok(validatedUser);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }  
    }
}