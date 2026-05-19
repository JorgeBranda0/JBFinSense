using JBFinSense.Application.Features.Auth.Interfaces;
using JBFinSense.Domain.Entities;

namespace JBFinSense.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}