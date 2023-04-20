using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public interface ICategoryRepository
    {
        Task<ResponseData<bool>> CreateCategory(Category category);
        Task<ResponseData<bool>> DeleteCategory(Category category);
        Task<ResponseData<List<Category>>> GetAllCategories();
        Task<ResponseData<Category>> GetCategoryById(long Id);
        Task<ResponseData<bool>> UpdateCategory(Category category);
    }
}
