using CargoTrack.Entity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.Manager.Controllers;

// Bu alandaki her controller bundan türer: kilit tek yerde, unutulamaz
[Area("Manager")]
[Authorize(Roles = RoleNames.Manager)]
public abstract class ManagerBaseController : Controller
{
}
