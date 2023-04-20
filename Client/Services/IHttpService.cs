using SimpleBlog.Shared.Helper;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Services
{
    public interface IHttpService
    {
        Task<ResponseData<object>> PostAsync<T>(string url, T data);
        Task<ResponseData<TResponse>> PostAsync<T, TResponse>(string url, T data);
        Task<ResponseData<T>> Get<T>(string url);

    }
}