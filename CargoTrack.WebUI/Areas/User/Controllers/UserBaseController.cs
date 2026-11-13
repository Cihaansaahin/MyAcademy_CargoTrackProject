using CargoTrack.Entity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CargoTrack.WebUI.Areas.User.Controllers;

// Bu alandaki her controller bundan türer: kilit tek yerde, unutulamaz
[Area("User")]
[Authorize(Roles = RoleNames.User)]
public abstract class UserBaseController : Controller
{
}
