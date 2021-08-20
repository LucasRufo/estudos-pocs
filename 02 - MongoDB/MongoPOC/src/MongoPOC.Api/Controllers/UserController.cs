using Microsoft.AspNetCore.Mvc;
using MongoPOC.Api.Models;
using MongoPOC.Api.Repository.Interfaces;
using System.Threading.Tasks;

namespace MongoPOC.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userRepository.GetAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user is null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            var ret = await _userRepository.InsertAsync(user);

            if (ret.HasError)
                return BadRequest(ret.Errors);

            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, User user)
        {
            if (id != user.Id)
                return BadRequest();

            var ret = await _userRepository.UpdateAsync(id, user);

            if (ret.HasError)
                return BadRequest(ret.Errors);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var ret = await _userRepository.DeleteAsync(id);

            if (ret.HasError)
                return BadRequest(ret.Errors);

            return Ok(ret.ReturnObject);
        }
    }
}