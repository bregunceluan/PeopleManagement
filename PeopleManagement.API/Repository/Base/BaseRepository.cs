using AutoMapper;
using PeopleManagement.API.Model.Context;

namespace PeopleManagement.API.Repository.Base
{
    public class BaseRepository<T>
    {
        private readonly RmContext _context;
        private IMapper _mapper;

        public BaseRepository(RmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public async Task<IEnumerable<T>> FindAll()
        //{
        //    var list = await _context.
        //}

    }
}
