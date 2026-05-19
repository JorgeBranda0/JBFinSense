using JBFinSense.Domain.Entities;

namespace JBFinSense.Application.Features.Auth.Interfaces
{
    public interface IJwtProvider
    {
        string Generate(User user);
    }
}
