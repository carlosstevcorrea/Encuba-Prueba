using Encuba.Ejemplo.Domain.Entities;
using Encuba.Ejemplo.Domain.Seed;

namespace Encuba.Ejemplo.Domain.Interfaces.Repositories;

public interface IPublicAccessTokenRepository : IRepository<PublicAccessToken>
{
    PublicAccessToken Add(PublicAccessToken publicAccessToken);
    PublicAccessToken Update(PublicAccessToken publicAccessToken);
    void Delete(List<PublicAccessToken> publicAccessTokens);
    Task<PublicAccessToken> GetByToken(string token);
    Task<PublicAccessToken> GetByRefreshToken(string refreshToken, string client);
}