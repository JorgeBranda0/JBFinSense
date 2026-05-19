using JBFinSense.Application.Features.Auth.DTOs;
using JBFinSense.Application.Features.Auth.Interfaces;
using JBFinSense.Domain.Entities;
using MediatR;

namespace JBFinSense.Application.Features.Auth.Commands.RegisterUser
{
    public class RegisterUserHandler(
        IUserRepository _repository,
        IPasswordHasher _passwordHasher,
        IJwtProvider _jwtProvider) 
        : IRequestHandler<RegisterUserCommand, AuthResponseDto>
    {
        public async Task<AuthResponseDto> Handle(RegisterUserCommand request, 
            CancellationToken cancellationToken)
        {
            var existingUser =
                await _repository.GetByEmailAsync(request.Email);

            if (existingUser is not null)
                throw new Exception("User already exists");

            var passwordHash =
                _passwordHasher.Hash(request.Password);

            var user = User.Create(
                request.Name,
                request.Email,
                passwordHash);

            await _repository.AddAsync(user);

            var token = _jwtProvider.Generate(user);

            return new AuthResponseDto(
                token,
                user.Id,
                user.Email);
        }
    }
}