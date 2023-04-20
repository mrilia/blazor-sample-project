using System.Collections.Generic;

namespace SimpleBlog.Shared.Entities
{
    public class Role
    {
        public long Id { get; set; }
        public string FaCaption { get; set; }
        public string EnCaption { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
