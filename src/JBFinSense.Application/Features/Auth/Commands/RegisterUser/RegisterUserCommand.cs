using JBFinSense.Application.Features.Auth.DTOs;
using MediatR;

namespace JBFinSense.Application.Features.Auth.Commands.RegisterUser
{
    public sealed record RegisterUserCommand(
        string Name,
        string Email,
        string Password) : IRequest<AuthResponseDto>;
}
