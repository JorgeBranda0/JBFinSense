using JBFinSense.Application.Features.Auth.Commands.RegisterUser;
using JBFinSense.Domain.Entities;

namespace JBFinSense.Application.Features.Auth.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<User?> GetByEmailAsync(string email);
    }
}