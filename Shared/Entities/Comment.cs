﻿using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.Shared.Entities
{
    public class Comment
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "وارد کردن عنوان الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "وارد کردن توضیحات الزامی است")]
        public string Description { get; set; }
        public long BlogId { get; set; }
        public long UserId { get; set; }
        public long ReplayTo { get; set; } = 0;
        public virtual Blog Blog { get; set; }
        public virtual User User { get; set; }
    }
}
