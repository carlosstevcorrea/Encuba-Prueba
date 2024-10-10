
using Encuba.Ejemplo.Domain.Entities;
using Encuba.Ejemplo.Domain.Seed;
using Microsoft.EntityFrameworkCore;

namespace Express.Trades.Security.Infrastructure;

public class SecurityDbContext(DbContextOptions<SecurityDbContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<User> Users { get; set; }
    public DbSet<PublicAccessToken> PublicAccessTokens { get; set; }
    public DbSet<UserPublicAccessToken> UserPublicAccessTokens { get; set; }

    public async Task<bool> SaveEntityAsync(CancellationToken cancellationToken = default)
    {
        await base.SaveChangesAsync(cancellationToken);
        return true;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var workerAssembly = typeof(SecurityDbContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(workerAssembly);
    }
}