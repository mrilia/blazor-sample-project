using SimpleBlog.Client.Services;
using SimpleBlog.Shared.DTO;
using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly IHttpService _http;
        private readonly string _URL = "api/users"; 
        public UserRepository(IHttpService http)
        {
            _http = http;
        }
        public async Task<ResponseData<List<Role>>> Roles()
        {
            var result = await _http.Get<List<Role>>($"{_URL}/roles");

            return result;
        }

        public async Task<ResponseData<bool>> CreateUser(User user)
        {
            var result = await _http.PostAsync<User , bool>($"{_URL}/createUser", user);

            return result;
        }

        public async Task<ResponseData<List<User>>> GetAllUsers()
        {
            var result = await _http.Get<List<User>>($"{_URL}/userList");

            return result;
        }

        public async Task<ResponseData<User>> GetUserById(long Id)
        {
            var result = await _http.PostAsync<long, User>($"{_URL}/getUserById" , Id);

            return result;
        }

        public async Task<ResponseData<bool>> UpdateUser(User user)
        {
            var result = await _http.PostAsync<User, bool>($"{_URL}/updateUser" , user);

            return result;
        }

        public async Task<ResponseData<bool>> DeleteUser(User user)
        {
            var result = await _http.PostAsync<User, bool>($"{_URL}/deleteUser" , user);

            return result;
        }

        public async Task<ResponseData<bool>> RegisterUser(RegisterDTO user)
        {
            var result = await _http.PostAsync<RegisterDTO, bool>($"{_URL}/registerUser", user);

            return result;
        }
    }
}
