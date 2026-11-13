namespace CargoTrack.Entity.Common;

// Rol adları tek yerde: [Authorize(Roles = RoleNames.Admin)] gibi yerlerde
// "Admn" yazım hatası derleme hatası olsun, sessiz yetki açığı değil.
public static class RoleNames
{
    public const string Admin = "Admin";
    public const string Manager = "Manager";
    public const string User = "User";

    public static readonly string[] All = [Admin, Manager, User];
}
