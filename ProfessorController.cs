using Microsoft.AspNetCore.Mvc;
using MyCoreApp.Models;

namespace MyCoreApp
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            OfficeDatabaseContext context = HttpContext.RequestServices.GetService(typeof(MyCoreApp.Models.OfficeDatabaseContext)) as OfficeDatabaseContext;

            return View(context.GetAllProfessor);
        }
    }
}
