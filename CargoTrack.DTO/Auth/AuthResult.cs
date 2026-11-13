namespace CargoTrack.DTO.Auth;

// Servis exception fırlatmak yerine sonuç döner (IdentityResult mantığı)
public class AuthResult
{
    public bool Succeeded { get; init; }
    public IReadOnlyList<string> Errors { get; init; } = [];

    // Login/register sonrası hangi panele gidileceğine controller karar versin diye
    public IReadOnlyList<string> Roles { get; init; } = [];

    public static AuthResult Success(params string[] roles) =>
        new() { Succeeded = true, Roles = roles };

    public static AuthResult Failure(params string[] errors) =>
        new() { Succeeded = false, Errors = errors };
}
