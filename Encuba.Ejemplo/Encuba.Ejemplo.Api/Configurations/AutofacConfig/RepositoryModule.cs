using Autofac;
using Encuba.Ejemplo.Domain.Interfaces.Cryptography;
using Encuba.Ejemplo.Domain.Interfaces.Repositories;
using Encuba.Ejemplo.Infrastructure.Cryptography;
using Encuba.Ejemplo.Infrastructure.Repositories;

namespace  Encuba.Ejemplo.Api.Configurations.AutofacConfig;

public class RepositoryModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<UserRepository>()
            .As<IUserRepository>()
            .InstancePerLifetimeScope();
        
        builder.RegisterType<UserPublicAccessTokenRepository>()
            .As<IUserPublicAccessTokenRepository>()
            .InstancePerLifetimeScope();
        
        builder.RegisterType<PublicAccessTokenRepository>()
            .As<IPublicAccessTokenRepository>()
            .InstancePerLifetimeScope();
        
        builder.RegisterType<BCryptCryptographyHelper >()
            .As<IBCryptCryptographyHelper >()
            .InstancePerLifetimeScope();
        
    }
}