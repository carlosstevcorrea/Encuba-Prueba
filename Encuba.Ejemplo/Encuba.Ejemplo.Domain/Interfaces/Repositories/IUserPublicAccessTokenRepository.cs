using Encuba.Ejemplo.Domain.Entities;
using Encuba.Ejemplo.Domain.Seed;

namespace Encuba.Ejemplo.Domain.Interfaces.Repositories;

public interface IUserPublicAccessTokenRepository : IRepository<UserPublicAccessToken>
{
    UserPublicAccessToken Add(UserPublicAccessToken userPublicAccessToken);
    void Delete(List<UserPublicAccessToken> userPublicAccessTokens);
    Task<UserPublicAccessToken> GetByUserIdAsync(Guid userId);
}