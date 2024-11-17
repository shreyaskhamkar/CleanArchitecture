using shreyaskhamkar.Application;
using shreyaskhamkar.Infrastructure;

namespace shreyaskhamkar.api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {

            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}
