using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.Admin.Controllers;

public class DashboardController : AdminBaseController
{
    public IActionResult Index() => View();
}
