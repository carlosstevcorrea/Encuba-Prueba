using Encuba.Ejemplo.Application.Commands.AuthJwtCommands;

namespace Encuba.Ejemplo.Api.Dtos.AuthJwtRequests;

public record CreateJwtRequest(string AccessToken)
{
    public CreateJwtCommand ToApplicationRequest(string secret)
    {
        return new CreateJwtCommand(AccessToken, secret);
    }
}