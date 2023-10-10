using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using new_backend.Repository;
using new_backend.Models;
using System.Security.Cryptography;

namespace new_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IcodeRepository _CodeRepository;

        public AttendanceController(IcodeRepository CodeRepository)
        {
            _CodeRepository = CodeRepository;
        }

        //action method for get all items
        [HttpGet("")]
        public async Task<IActionResult> GetAllDetails()
        {
            var loginDetails = await _CodeRepository.GetAllValidationsAsync();
            return Ok(loginDetails);
        }

        //for single item
        [HttpGet("")]
        public async Task<IActionResult> GetValidationsById([FromRoute] int id)
        {
            var login = await _CodeRepository.GetValidationsByIdAsync(id);
            if (login == null)
            {
                return NotFound();
            }
            return Ok(login);
        }

        //for add item
        [HttpPost("")]
        public async Task<IActionResult> AddNewLogin([FromBody]Validation validation)
        {
            var id = await _CodeRepository.AddValidationsAsync(validation);
            return CreatedAtAction(nameof(GetValidationsById),new {id = id,controller = "loginDetails"}, id);
        }

        //update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLogin([FromBody] Validation validation, [FromRoute]int id)
        {
            await _CodeRepository.UpdateValidationsByIdAsync(id,validation);
            return Ok();
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogin([FromRoute] int id)
        {
            await _CodeRepository.DeleteValidationsAsync(id);
            return Ok();
        }
    }
}
