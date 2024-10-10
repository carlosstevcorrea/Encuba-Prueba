
using Encuba.Ejemplo.Application.Dtos.Responses;
using Encuba.Ejemplo.Domain.Dtos;
using MediatR;

namespace Encuba.Ejemplo.Application.Commands.AuthUserCommands;

public record LoginUserCommand(
    string Username,
    string Password,
    string UserAgent,
    string ClientIp) : IRequest<EntityResponse<PublicAccessTokenResponse>>;