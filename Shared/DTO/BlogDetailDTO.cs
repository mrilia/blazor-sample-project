using SimpleBlog.Shared.Entities;
using System.Collections.Generic;

namespace SimpleBlog.Shared.DTO
{
    public class BlogDetailDTO
    {
        public Blog Blog { get; set; }
        public List<Blog> LastBlogs { get; set; }
    }
}
