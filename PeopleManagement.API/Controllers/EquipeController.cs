using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Repository.Base;
using PeopleManagement.API.Repository;

namespace PeopleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipeController : ControllerBase
    {
        private IBaseRepository<EquipeDTO> _repository;

        public EquipeController(EquipeRepository equipeRepository)
        {
            _repository = equipeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<EquipeDTO>>> FindByAll()
        {
            var cargos = await _repository.FindAll();
            return Ok(cargos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EquipeDTO>> FindById(long id)
        {
            var equipe = await _repository.FindById(id);
            if (equipe == null) return NotFound();
            return Ok(equipe);
        }

        [HttpPost]
        public async Task<ActionResult<EquipeDTO>> Create(EquipeDTO dto)
        {
            if (dto == null) return BadRequest();
            var equipe = await _repository.Create(dto);
            return Ok(equipe);
        }

        [HttpPut]
        public async Task<ActionResult<EquipeDTO>> Update(EquipeDTO dto)
        {
            if (dto == null) return BadRequest();
            var equipe = await _repository.Update(dto);
            return Ok(equipe);
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
