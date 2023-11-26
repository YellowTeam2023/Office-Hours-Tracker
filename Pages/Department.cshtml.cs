using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCoreApp.Pages
{
    public class DepartmentModel : PageModel
    {
        [BindProperty]
        public String DepartmentName { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            DepartmentName = Request.Form["DepartmentForm"];
        }
    }
}
