using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.User.Controllers;

public class DashboardController : UserBaseController
{
    public IActionResult Index() => View();
}
