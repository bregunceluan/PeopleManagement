using AutoMapper;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Model.Context;
using PeopleManagement.API.Model;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Repository.Base;

namespace PeopleManagement.API.Repository
{
    public class EquipeRepository : IBaseRepository<EquipeDTO>
    {
        private readonly RmContext _context;
        private IMapper _mapper;

        public EquipeRepository(RmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EquipeDTO>> FindAll()
        {
            var list = await _context.Equipes.ToListAsync();
            return _mapper.Map<List<EquipeDTO>>(list);
        }

        public async Task<EquipeDTO> FindById(long id)
        {
            var product = await _context.Equipes.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<EquipeDTO>(product);
        }

        public async Task<EquipeDTO> Create(EquipeDTO dto)
        {
            Equipe equipe = _mapper.Map<Equipe>(dto);
            _context.Equipes.Add(equipe);
            await _context.SaveChangesAsync();
            return _mapper.Map<EquipeDTO>(equipe);
        }

        public async Task<EquipeDTO> Update(EquipeDTO dto)
        {
            Equipe equipe = _mapper.Map<Equipe>(dto);
            _context.Equipes.Update(equipe);
            await _context.SaveChangesAsync();
            return _mapper.Map<EquipeDTO>(equipe);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var equipe = await _context.Equipes.FirstOrDefaultAsync(x => x.Id == id);
                if (equipe == null) return false;
                _context.Remove(equipe);
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
