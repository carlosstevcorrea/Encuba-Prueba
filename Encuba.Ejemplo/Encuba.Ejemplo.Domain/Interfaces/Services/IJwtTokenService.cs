using Encuba.Ejemplo.Domain.Dtos;

namespace Encuba.Ejemplo.Domain.Interfaces.Services;

public interface IJwtTokenService
{
    
    public string GenerateJwtToken(JwtPayloadDto payload);
}