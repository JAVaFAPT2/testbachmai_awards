using Aplication.service.HumanData.Commands.Handler;
using Autofac;
using Autofac.Features.Variance;

namespace Aplication;

public static class ContainerConfig
{
    public static ContainerBuilder AddGenericHandlers(this ContainerBuilder builder)
    {
        builder.RegisterSource(new ContravariantRegistrationSource());

        // Register command and query handlers
        builder.RegisterType<CreatePersonCommandHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<DeletePersonCommandHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<UpdatePersonCommandHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<GetAllPeopleQueryHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<GetPersonByIdQueryHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<GetPeoplesByEmailQueryHandler>()
            .AsImplementedInterfaces();
        builder.RegisterType<LoginQueriesHandler>()
            .AsImplementedInterfaces();

        builder.RegisterType<RegisterCommandHandler>()
            .AsImplementedInterfaces();

        //Add more here
        return builder;
    }
}