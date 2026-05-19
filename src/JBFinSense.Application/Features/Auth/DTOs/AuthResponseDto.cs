namespace JBFinSense.Application.Features.Auth.DTOs
{
    public sealed record AuthResponseDto(
        string Token,
        Guid UserId,
        string Email);
}
