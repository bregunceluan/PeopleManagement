using AutoMapper;
using PeopleManagement.API.Data.DTOs;
using PeopleManagement.API.Model.Context;
using PeopleManagement.API.Model;
using Microsoft.EntityFrameworkCore;
using PeopleManagement.API.Repository.Base;

namespace PeopleManagement.API.Repository
{
    public class UserRepository : IBaseRepository<UserDTO>
    {
        private readonly RmContext _context;
        private IMapper _mapper;

        public UserRepository(RmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> FindAll()
        {
            var list = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserDTO>>(list);
        }

        public async Task<UserDTO> FindById(long id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<UserDTO>(user);
        }

 
        public async Task<UserDTO> Create(UserDTO dto)
        {
            User user = _mapper.Map<User>(dto);
            var cargo = await _context.Cargos.FirstOrDefaultAsync(c=>c.Id == user.CargoId);
            if (cargo == null) return null;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> Update(UserDTO dto)
        {
            User user = _mapper.Map<User>(dto);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
                if (user == null) return false;
                _context.Remove(user);
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
