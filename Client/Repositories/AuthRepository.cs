using SimpleBlog.Client.Services;
using SimpleBlog.Shared.Helper;
using System;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IHttpService _httpService;
        private readonly string authUrl = "api/auth";
        public AuthRepository(IHttpService http)
        {
            _httpService = http;
        }
        public async Task<TokenData> Login(UserData userData)
        {
            var response = await _httpService.PostAsync<UserData, TokenData>($"{authUrl}/login", userData);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
    
}