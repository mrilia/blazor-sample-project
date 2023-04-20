using SimpleBlog.Shared.Helper;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public interface IAuthRepository
    {
        Task<TokenData> Login(UserData userData);
    }
}