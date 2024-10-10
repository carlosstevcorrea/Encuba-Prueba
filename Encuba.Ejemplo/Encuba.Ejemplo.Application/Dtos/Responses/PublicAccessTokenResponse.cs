using Encuba.Ejemplo.Domain.Dtos;
using MediatR;

namespace Encuba.Ejemplo.Application.Dtos.Responses;

public record PublicAccessTokenResponse(
    string AccessToken,
    string RefreshToken,
    string Scope,
    DateTime ExpiresIn): IRequest<EntityResponse<PublicAccessTokenResponse>>;