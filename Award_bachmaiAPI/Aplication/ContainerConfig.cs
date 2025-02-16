using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.service.HumanData.Commands.Handler;
using Autofac;
using Autofac.Features.Variance;

namespace Aplication
{
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

            return builder;
        }
    }
}
