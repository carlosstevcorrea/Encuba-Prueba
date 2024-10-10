namespace Encuba.Ejemplo.Domain.Seed;

public interface IRepository<T>
    where T : class
{
    IUnitOfWork UnitOfWork { get; }
}