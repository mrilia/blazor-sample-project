using SimpleBlog.Shared.Entities;
using System.Threading.Tasks;

namespace SimpleBlog.Client.Pages.Admin.CategoryComponents
{
    public partial class Create
    {
        public Category category { get; set; } = new Category();
        public string Message = null;
        public bool ShowMessage = false;

        private async Task CreateCategory()
        {

            var response = await categoryRepository.CreateCategory(category);
            ShowMessage = true;
            if (response.Success)
            {
                if (response.Response)
                {
                    Message = "عملیات با موفقیت انجام شد";
                }
                else
                {
                    Message = "در ثبت اطلاعات خطایی رخ داد";
                }
            }
            else
            {
                Message = "درخواست شما انجام نشد";
            }
        }
    }
}
