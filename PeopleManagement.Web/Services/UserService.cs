using Newtonsoft.Json;
using PeopleManagement.Web.Models;
using PeopleManagement.Web.Services.Interfaces;

namespace PeopleManagement.Web.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private const string BasePath = "api/user";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var response = await _httpClient.GetAsync(BasePath);
            var result = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(result);
            return users;
        }

        public Task<User> CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(long id)
        {
            throw new NotImplementedException();
        }



        public Task<User> GetUserById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
