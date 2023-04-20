using SimpleBlog.Shared.Entities;
using SimpleBlog.Shared.Helper;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Pages.Admin.BlogComponents
{
    public partial class List
    {
        public List<Blog> Blogs;
        public ResponseData<List<Blog>> Response;
        public string Message = null;
        public bool ShowMessage = false;
        [Parameter]
        public long Id { get; set; } = 0;

        protected async override Task OnInitializedAsync()
        {
            if (Id > 0)
            {
                Response = await blogRepository.GetBlogsWithUserId(Id);
            }
            else
            {
                Response = await blogRepository.GetAllBlogs();
            }
            ShowMessage = true;
            if (Response.Success)
            {
                Message = $"تعداد رکورد های دریافتی برابر با {Response.Response.Count}";
                if (Response.Response != null && Response.Response.Count > 0)
                {
                    Blogs = Response.Response;
                }
                else
                {
                    Blogs = new List<Blog>();
                }
            }
            else
            {
                Message = "دریافت اطلاعات با خطا مواجه شد";
            }
        }

        private void EditBlog(long Id)
        {
            navigation.NavigateTo($"/admin/blogs/edit/{Id}");
        }

        private async Task DeleteBlog(Blog blog)
        {
            var result = await blogRepository.DeleteBlog(blog);
            ShowMessage = true;
            if (result.Success)
            {
                if (result.Response)
                {
                    Message = "مقاله مورد نظر حذف شد";
                    Blogs.Remove(blog);
                }
                else
                {
                    Message = "انجام عملیات با خطا مواجه شد";
                }
            }
            else
            {
                Message = "درخواست شما با خطا مواجه شد";
            }
        }
    }
}
