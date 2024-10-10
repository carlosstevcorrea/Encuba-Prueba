

using Encuba.Ejemplo.Domain.Entities;
using Encuba.Ejemplo.Domain.Interfaces.Repositories;
using Encuba.Ejemplo.Domain.Seed;
using Express.Trades.Security.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Encuba.Ejemplo.Infrastructure.Repositories;

public class PublicAccessTokenRepository(
    SecurityDbContext dbContext ): IPublicAccessTokenRepository
{
    public IUnitOfWork UnitOfWork => dbContext;
    public PublicAccessToken Add(PublicAccessToken publicAccessToken)
    {
        return dbContext.PublicAccessTokens.Add(publicAccessToken).Entity;
    }

    public PublicAccessToken Update(PublicAccessToken publicAccessToken)
    {
        return dbContext.PublicAccessTokens.Update(publicAccessToken).Entity;
    }

    public void Delete(List<PublicAccessToken> publicAccessTokens)
    {
        dbContext.PublicAccessTokens.RemoveRange(publicAccessTokens);
    }
    
    public async Task<PublicAccessToken> GetByToken(string token)
    {
        return (await dbContext.PublicAccessTokens.FirstOrDefaultAsync(t => t.AccessToken.Equals(token))!)!;
    }
    
    public async Task<PublicAccessToken> GetByRefreshToken(string refreshToken, string client)
    {
        return (await dbContext.PublicAccessTokens.FirstOrDefaultAsync(t =>
            t.RefreshToken.Equals(refreshToken) && t.Scope.Equals(client))!)!;
    }
}