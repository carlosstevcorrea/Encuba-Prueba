
using Encuba.Ejemplo.Domain.Dtos;
using MediatR;

namespace Encuba.Ejemplo.Application.Commands.AuthJwtCommands;

public record CreateJwtCommand(
    string AccessToken,
    string JwtSecret) : IRequest<EntityResponse<JwtResponse>>;