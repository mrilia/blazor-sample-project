using SimpleBlog.Client.Services;
using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly IHttpService _http;
        private readonly string _URL = "api/categories";
        public CategoryRepository(IHttpService http)
        {
            _http = http;
        }

        public async Task<ResponseData<bool>> CreateCategory(Category category)
        {
            var result = await _http.PostAsync<Category, bool>($"{_URL}/createCategory", category);

            return result;
        }

        public async Task<ResponseData<List<Category>>> GetAllCategories()
        {
            var result = await _http.Get<List<Category>>($"{_URL}/categoryList");

            return result;
        }

        public async Task<ResponseData<Category>> GetCategoryById(long Id)
        {
            var result = await _http.PostAsync<long, Category>($"{_URL}/getCategoryById", Id);

            return result;
        }

        public async Task<ResponseData<bool>> UpdateCategory(Category category)
        {
            var result = await _http.PostAsync<Category, bool>($"{_URL}/updateCategory", category);

            return result;
        }

        public async Task<ResponseData<bool>> DeleteCategory(Category category)
        {
            var result = await _http.PostAsync<Category, bool>($"{_URL}/deleteCategory", category);

            return result;
        }
    }
}
