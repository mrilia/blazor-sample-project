using SimpleBlog.Shared.DTO;
using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public interface IUserRepository
    {
        Task<ResponseData<bool>> CreateUser(User user);
        Task<ResponseData<bool>> RegisterUser(RegisterDTO user);
        Task<ResponseData<bool>> DeleteUser(User user);
        Task<ResponseData<List<User>>> GetAllUsers();
        Task<ResponseData<User>> GetUserById(long Id);
        Task<ResponseData<List<Role>>> Roles();
        Task<ResponseData<bool>> UpdateUser(User user);
    }
}
