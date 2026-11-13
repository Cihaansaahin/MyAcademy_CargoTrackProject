using CargoTrack.Entity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.Admin.Controllers;

// Bu alandaki her controller bundan türer: kilit tek yerde, unutulamaz
[Area("Admin")]
[Authorize(Roles = RoleNames.Admin)]
public abstract class AdminBaseController : Controller
{
}
