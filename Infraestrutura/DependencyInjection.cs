using MediatR.Extensions.FluentValidation.AspNetCore;

namespace Vinculo_Net_Api.Infraestrutura;

public static class DependencyInjection
{
    public static IServiceCollection AddLibs(this IServiceCollection services, Configuracao configuracao)
    {
        services.AddAutoMapper(configuracao.Assemblies);

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies([.. configuracao.Assemblies]);
            foreach (var openBehavior in configuracao.ComportamentosAbertos.AsParallel())
                cfg.AddOpenBehavior(openBehavior);
        });

        services.AddFluentValidation(configuracao.Assemblies);
        return services;
    }
}