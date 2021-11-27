using Jr.Backend.Libs.Infrastructure.MongoDB.Abstractions;
using Jr.Backend.Libs.Infrastructure.MongoDB.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace $safeprojectname$.DependencyInjection
{
    public static class ServicesDependency
    {
        public static void AddServiceDependencyInfrastructure(this IServiceCollection services)
        {
            services.AddServiceDependencyJrInfrastructureMongoDb(ConnectionType.DirectConnection);
        }
    }
}