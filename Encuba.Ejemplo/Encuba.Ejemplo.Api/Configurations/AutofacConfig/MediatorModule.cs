using System.Reflection;
using Autofac;
using Encuba.Ejemplo.Application.Commands.UserCommands;
using MediatR;
using Module = Autofac.Module;

namespace Encuba.Ejemplo.Api.Configurations.AutofacConfig;

public class MediatorModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
            .AsImplementedInterfaces();

        builder.RegisterAssemblyTypes(typeof(CreateUserCommand).GetTypeInfo().Assembly)
            .AsClosedTypesOf(typeof(IRequestHandler<,>));

    }
}