namespace Encuba.Ejemplo.Domain.Dtos;

public record JwtPayloadDto(
    Guid Id,
    string FullName,
    string Scope
);