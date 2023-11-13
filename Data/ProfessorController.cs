using Microsoft.AspNetCore.Mvc;
using MyCoreApp.Data;
using MyCoreApp.Models;
using System.Threading.Tasks;

public class ProfessorController : Controller
{
    public async Task<IActionResult> ProfessorList()
    {
        var professorService = new ProfessorDetailService();
        var professors = await professorService.GetProfessorInfo();
        return View(professors);
    }
}
