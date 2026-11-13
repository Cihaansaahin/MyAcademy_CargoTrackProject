using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.Manager.Controllers;

public class DashboardController : ManagerBaseController
{
    public IActionResult Index() => View();
}
