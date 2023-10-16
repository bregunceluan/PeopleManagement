using PeopleManagement.Web.Models;

namespace PeopleManagement.Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(long id);
        Task<User> CreateUser(User user);
        Task<User> UpdateUser(User user);
        Task<bool> DeleteUser(long id);

    }
}
