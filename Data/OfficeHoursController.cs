using Microsoft.AspNetCore.Mvc;
using MyCoreApp.Data;
using MyCoreApp.Models;
using System.Threading.Tasks;


public class OfficeHoursController : Controller
{
    public async Task<IActionResult> OfficeHoursList()
    {
        var officeHoursService = new OfficeHoursDetailService();
        var officehours = await officeHoursService.GetOfficeHoursInfo("");
        return View(officehours);
    }
}