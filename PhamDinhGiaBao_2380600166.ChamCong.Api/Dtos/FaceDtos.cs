using System.ComponentModel.DataAnnotations;

namespace PhamDinhGiaBao_2380600166.ChamCong.Api.Dtos;

public class FaceEnrollRequest
{
    [Required] public float[]? Embedding { get; set; }
}

public class FaceVerifyRequest
{
    [Required] public float[]? Embedding { get; set; }
}

public class FaceLoginRequest
{
    [Required] public string? Username { get; set; }
    [Required] public float[]? Embedding { get; set; }
}

public record FaceVerifyResponse(bool Matched, double Score, string? FaceToken, int? FaceTokenExpiresIn);
