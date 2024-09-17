using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/controllers")]
    public class UsersController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        [HttpPut("{id}")]
        public IActionResult PutById(int id, [FromBody] UpdateUserModel updateUserModel) 
        {
            if (updateUserModel == null)
            {
                return BadRequest();
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            if (id == 0 || id == null)
            {
                return BadRequest();
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPut("{id}/login")]
        public IActionResult Login(int id, LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
