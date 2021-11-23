using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdultsAPI.Data;
using Microsoft.AspNetCore.Mvc;
using AdultsApi.Models;

namespace AdultsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private IAdultsService adultsService;

        public AdultsController(IAdultsService adultsService)
        {
            this.adultsService = adultsService;
        }


        [HttpGet]
        public async Task<ActionResult<IList<Adult>>>
            GetAdults([FromQuery] int? userId, [FromQuery] bool? isCompleted)
        {
            try
            {
                IList<Adult> adults = await adultsService.GetAdultsAsync();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteAdult([FromRoute] int id)
        {
            try
            {
                await adultsService.RemoveAdultAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Adult added = await adultsService.AddAdultAsync(adult);
                return Created($"/{added.Id}", added); // return newly added adult, to get the auto generated id
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult)
        {
            try
            {
                Adult updatedAdult = await adultsService.UpdateAsync(adult);
                return Ok(updatedAdult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }



    }
}