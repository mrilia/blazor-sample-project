using System.Collections.Generic;

namespace SimpleBlog.Shared.Entities
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
