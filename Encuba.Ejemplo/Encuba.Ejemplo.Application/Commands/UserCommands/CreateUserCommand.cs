using Encuba.Ejemplo.Application.Dtos.Responses;
using Encuba.Ejemplo.Domain.Dtos;
using MediatR;

namespace Encuba.Ejemplo.Application.Commands.UserCommands;

public record CreateUserCommand(
    string UserName,
    string UserType,
    string FirstName,
    string SecondName,
    string FirstLastName,
    string SecondLastName,
    string Password,
    string Email,
    bool AcceptedTermsAndCondition
) : IRequest<EntityResponse<ObjectIdResponse>>;