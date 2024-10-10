using Encuba.Ejemplo.Domain.Entities;
using Encuba.Ejemplo.Domain.Seed;

namespace Encuba.Ejemplo.Domain.Interfaces.Repositories;

public interface IUserRepository : IRepository<User>
{
    User Add(User user);
    User Update(User user);
    
    Task<User> GetByUserAsync(string userName);
}