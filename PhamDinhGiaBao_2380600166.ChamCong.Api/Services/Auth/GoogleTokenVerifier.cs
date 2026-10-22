using Google.Apis.Auth;
using Microsoft.Extensions.Options;
using PhamDinhGiaBao_2380600166.ChamCong.Api.Options;

namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Services.Auth;

public record GoogleIdentity(string Subject, string? Email, bool EmailVerified, string? Name);

public interface IGoogleTokenVerifier
{
    Task<GoogleIdentity> VerifyAsync(string idToken, CancellationToken ct = default);
}

public class GoogleTokenVerifier(IOptions<GoogleOptions> options) : IGoogleTokenVerifier
{
    public async Task<GoogleIdentity> VerifyAsync(string idToken, CancellationToken ct = default)
    {
        var clientId = options.Value.WebClientId;
        if (string.IsNullOrWhiteSpace(clientId))
            throw AppException.BadRequest("Google Sign-In chua duoc cau hinh (Google:WebClientId)");

        try
        {
            var p = await GoogleJsonWebSignature.ValidateAsync(idToken,
                new GoogleJsonWebSignature.ValidationSettings { Audience = [clientId] });
            return new GoogleIdentity(p.Subject, p.Email, p.EmailVerified, p.Name);
        }
        catch (InvalidJwtException)
        {
            throw AppException.Unauthorized("Google idToken khong hop le");
        }
    }
}
