using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCoreApp.Pages
{
    public class DepartmentModel : PageModel
    {
        private readonly ILogger<DepartmentModel> _logger;

        public DepartmentModel(ILogger<DepartmentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToShortDateString();
            ViewData["TimeStamp"] = dateTime;
        }
    }
}