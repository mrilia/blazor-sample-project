using SimpleBlog.Shared.DTO;
using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Repositories
{
    public interface IBlogRepository
    {
        Task<ResponseData<bool>> CreateBlog(Blog blog);
        Task<ResponseData<bool>> SendComment(Comment comment);
        Task<ResponseData<bool>> DeleteBlog(Blog blog);
        Task<ResponseData<List<Blog>>> GetAllBlogs();
        Task<ResponseData<List<Blog>>> GetBlogsWithUserId(long UserId);
        Task<ResponseData<Blog>> GetBlogById(long Id);
        Task<ResponseData<bool>> LikeBlog(long Id);
        Task<ResponseData<BlogDetailDTO>> GetBlogDetail(long Id);
        Task<ResponseData<bool>> UpdateBlog(Blog blog);
    }
}
