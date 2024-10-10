using Encuba.Ejemplo.Application.Commands.AuthUserCommands;

namespace Encuba.Ejemplo.Api.Dtos.AuthUserRequests;

public record RefreshTokenRequest(string RefreshToken)
{
    public RefreshTokenCommand ToApplicationRequest()
    {
        return new RefreshTokenCommand(RefreshToken);
    }
}