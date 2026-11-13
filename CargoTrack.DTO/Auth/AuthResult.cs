namespace CargoTrack.DTO.Auth;

// Servis exception fırlatmak yerine sonuç döner (IdentityResult mantığı)
public class AuthResult
{
    public bool Succeeded { get; init; }
    public IReadOnlyList<string> Errors { get; init; } = [];

    public static AuthResult Success() => new() { Succeeded = true };

    public static AuthResult Failure(params string[] errors) =>
        new() { Succeeded = false, Errors = errors };
}
