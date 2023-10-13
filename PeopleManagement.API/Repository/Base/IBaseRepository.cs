namespace PeopleManagement.API.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> FindAll();
        Task<T> FindById(long id);
        Task<T> Create(T dto);
        Task<T> Update(T dto);
        Task<bool> Delete(long id);
    }
}
