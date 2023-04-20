using SimpleBlog.Shared.Helper;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Services
{
    public interface IUserAuthService
    {
        Task Login(TokenData tokenData);
        Task Logout();
        Task<bool> CheckToken();
        Task CleanUp();
    }
}