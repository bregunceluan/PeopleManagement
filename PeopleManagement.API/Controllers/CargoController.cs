using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Repository;
using PeopleManagement.API.Repository.Base;

namespace PeopleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private IBaseRepository<CargoDTO> _repository;

        public CargoController(CargoRepository cargoRepository)
        {
            _repository = cargoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<CargoDTO>>> FindByAll()
        {
            var cargos = await _repository.FindAll();
            return Ok(cargos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CargoDTO>> FindById(long id)
        {
            var cargo = await _repository.FindById(id);
            if (cargo == null) return NotFound();
            return Ok(cargo);
        }

        [HttpPost]
        public async Task<ActionResult<CargoDTO>> Create(CargoDTO dto)
        {
            if (dto == null) return BadRequest();
            var cargo = await _repository.Create(dto);
            return Ok(cargo);
        }

        [HttpPut]
        public async Task<ActionResult<CargoDTO>> Update(CargoDTO dto)
        {
            if (dto == null) return BadRequest();
            var cargo = await _repository.Update(dto);
            return Ok(cargo);
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
