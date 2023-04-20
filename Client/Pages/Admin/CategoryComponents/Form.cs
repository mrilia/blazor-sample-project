using SimpleBlog.Shared.Entities;
using Microsoft.AspNetCore.Components;

namespace SimpleBlog.Client.Pages.Admin.CategoryComponents
{
    public partial class Form
    {
        [Parameter]
        public Category category { get; set; }
        [Parameter]
        public EventCallback SubmitCallback { get; set; }
    }
}
