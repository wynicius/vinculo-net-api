using MediatR.Extensions.FluentValidation.AspNetCore;

namespace Vinculo_Net_Api.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddLibs(this IServiceCollection services, Configuracao configuracao)
    {
        services.AddAutoMapper(configuracao.Assemblies);

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(configuracao.Assemblies.ToArray());
            foreach (var openBehavior in configuracao.ComportamentosAbertos.AsParallel())
                cfg.AddOpenBehavior(openBehavior);
        });

        services.AddFluentValidation(configuracao.Assemblies);
        return services;
    }
}