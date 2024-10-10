using Encuba.Ejemplo.Application.Dtos.Responses;
using Encuba.Ejemplo.Domain.Dtos;
using MediatR;

namespace Encuba.Ejemplo.Application.Commands.AuthUserCommands;

public record RefreshTokenCommand(
    string RefreshToken) : IRequest<EntityResponse<PublicAccessTokenResponse>>;