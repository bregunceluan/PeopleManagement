using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Model;
using PeopleManagement.API.Model.Context;
using PeopleManagement.API.Repository.Base;

namespace PeopleManagement.API.Repository
{
    public class CargoRepository : IBaseRepository<CargoDTO>
    {
        private readonly RmContext _context;
        private IMapper _mapper;

        public CargoRepository(RmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CargoDTO>> FindAll()
        {
            var list = await _context.Cargos.ToListAsync();
            return _mapper.Map<List<CargoDTO>>(list);
        }

        public async Task<CargoDTO> FindById(long id)
        {
            var product = await _context.Cargos.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<CargoDTO>(product);
        }

        public async Task<CargoDTO> Create(CargoDTO dto)
        {
            Cargo cargo = _mapper.Map<Cargo>(dto);
            _context.Cargos.Add(cargo);
            await _context.SaveChangesAsync();
            return _mapper.Map<CargoDTO>(cargo);
        }

        public async Task<CargoDTO> Update(CargoDTO dto)
        {
            Cargo cargo = _mapper.Map<Cargo>(dto);
            _context.Cargos.Update(cargo);
            await _context.SaveChangesAsync();
            return _mapper.Map<CargoDTO>(cargo);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var cargo = await _context.Cargos.FirstOrDefaultAsync(x => x.Id == id);
                if (cargo == null) return false;
                _context.Remove(cargo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
