using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Repository.Base;
using PeopleManagement.API.Repository;

namespace PeopleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserRepository _repository;

        public UserController(UserRepository userRepository)
        {
            _repository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> FindByAll()
        {
            var cargos = await _repository.FindAll();
            return Ok(cargos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTO>> FindById(long id)
        {
            var user = await _repository.FindById(id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> Create(UserDTO dto)
        {
            if (dto == null) return BadRequest();
            var user = await _repository.Create(dto);
            if (user == null) return BadRequest("Cargo não existe");
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<UserDTO>> Update(UserDTO dto)
        {
            if (dto == null) return BadRequest();
            var user = await _repository.Update(dto);
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var response = await _repository.Delete(id);
            if (!response) return BadRequest();
            return Ok(response);
        }
    }
}
